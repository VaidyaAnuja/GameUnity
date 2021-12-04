using UnityEngine;

public class player2dcontroller : MonoBehaviour
{
    public float MovementSpeed = 3;
    public float JumpForce = 8;
    bool is_grounded;
    public Transform groundcheck;
    public LayerMask groundlayer;
    private SpriteRenderer colorrenderer_player;
    public SpriteRenderer colorrenderer_specialtile;

    public SpriteRenderer colorrenderer_specialvertical;
    public Sprite gamechar2;
    public Sprite gamechar3;
    public Sprite gamechar4;

    public Sprite tile1;
    public Sprite tile2;
    public Sprite tile3;

    public Sprite verical1;
    public Sprite vertical2;
    public Sprite vertical3;
    public GameObject v1; 
    public GameObject v2; 
    public GameObject v3; 
    public GameObject colorchangertile;
    public GameObject colorchangervertical; 
     private BoxCollider2D collider_player;
     public BoxCollider2D collider_v1;
     public BoxCollider2D collider_v2;
     public BoxCollider2D collider_v3;

     public BoxCollider2D collider_specialvertical;

     public float timeLeft_1 = 5.0f;
     public float timeLeft_2 = 5.0f;
     public float timeLeft_3 = 5.0f;

     public float timeLeft_vertical = 5.0f;
     //public float after = 5.0f;
    // Start is called before the first frame update
    private void Start()
    {
        colorrenderer_player = GetComponent<SpriteRenderer>();
        collider_player = GetComponent<BoxCollider2D>();
        collider_v1 = v1.GetComponent<BoxCollider2D>();
        collider_v2 = v2.GetComponent<BoxCollider2D>();
        collider_v3 = v3.GetComponent<BoxCollider2D>();
        colorrenderer_specialtile = colorchangertile.GetComponent<SpriteRenderer>();
        colorrenderer_specialvertical = colorchangervertical.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        is_grounded = Physics2D.OverlapCircle(groundcheck.position, 1.5f, groundlayer);
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            if(is_grounded){
               // collider_player.enabled = false;
        Jump();
        }}
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;
        Vector3 characterScale = transform.localScale;
        if(Input.GetAxis("Horizontal") < 0){
            characterScale.x = -0.3f;
        }
        if(Input.GetAxis("Horizontal") > 0){
            characterScale.x = 0.3f;
        }

        transform.localScale = characterScale;

        if(transform.position.y < -3){
            // GameController.isGameOver = true;
            Debug.Log("Dead");
        }

        if (collider_v1.enabled == false){
            timeLeft_1 -= Time.deltaTime;
                if (timeLeft_1 < 0)
                {
                    collider_v1.enabled = true;
                    timeLeft_1 = 5.0f;
                }}

                if (collider_v2.enabled == false){
            timeLeft_2 -= Time.deltaTime;
                if (timeLeft_2 < 0)
                {
                    collider_v2.enabled = true;
                    timeLeft_2 = 5.0f;
                }}

                if (collider_v3.enabled == false){
            timeLeft_3 -= Time.deltaTime;
                if (timeLeft_3 < 0)
                {
                    collider_v3.enabled = true;
                    timeLeft_3 = 5.0f;
                }}

                if (collider_specialvertical.enabled == false){
            timeLeft_vertical -= Time.deltaTime;
                if (timeLeft_vertical < 0)
                {
                    collider_specialvertical.enabled = true;
                    timeLeft_vertical = 5.0f;
                }}

        //         if (collider_player.enabled == false){
        //    after -= Time.deltaTime;
        //         if (after < 0)
        //         {
        //             collider_player.enabled = true;
        //             after = 3.0f;
        //         }}


    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.name == "tile1"){
            
            if(colorrenderer_player.sprite == gamechar2){
                collider_player.enabled = true;
            }
            else{
                collider_player.enabled = false;
            }
        }

        if(col.gameObject.name == "tile2"){
            if(colorrenderer_player.sprite == gamechar3){
                collider_player.enabled = true;
            }
            else{
                collider_player.enabled = false;
            }
        }

        if(col.gameObject.name == "tile3"){
            if(colorrenderer_player.sprite == gamechar4){
                collider_player.enabled = true;
            }
            else{
                collider_player.enabled = false;
            }
        }

        if(col.gameObject.name == "tilecolorchanger"){
            if((colorrenderer_player.sprite == gamechar2) && (colorrenderer_specialtile.sprite == tile1)){
                collider_player.enabled = true;
            }

            else if((colorrenderer_player.sprite == gamechar3) && (colorrenderer_specialtile.sprite == tile2)){
                collider_player.enabled = true;
            }

            else if((colorrenderer_player.sprite == gamechar4) && (colorrenderer_specialtile.sprite == tile3)){
                collider_player.enabled = true;
            }

            else{
                collider_player.enabled = false;
            }
        }

        if(col.gameObject.name == "vertical_colorchanger"){
            if((colorrenderer_player.sprite == gamechar2) && (colorrenderer_specialvertical.sprite == verical1)){
                collider_specialvertical.enabled = true;
            }

            else if((colorrenderer_player.sprite == gamechar3) && (colorrenderer_specialvertical.sprite == vertical2)){
                collider_specialvertical.enabled = true;
            }

            else if((colorrenderer_player.sprite == gamechar4) && (colorrenderer_specialvertical.sprite == vertical3)){
                collider_specialvertical.enabled = true;
            }

            else{
                collider_specialvertical.enabled = false;
            }
        }

       

if(col.gameObject.name == "vertical_block_1"){
            if(colorrenderer_player.sprite == gamechar2){
                collider_v1.enabled = true;
            }
            else{
                collider_v1.enabled = false;
                 
            }
        }

        if(col.gameObject.name == "vertical_block_2"){
            if(colorrenderer_player.sprite == gamechar3){
                collider_v2.enabled = true;
            }
            else{
                collider_v2.enabled = false;
                 
            }
        }

        if(col.gameObject.name == "vertical_block_3"){
            if(colorrenderer_player.sprite == gamechar4){
                collider_v3.enabled = true;
            }
            else{
                collider_v3.enabled = false;
                 
            }
        }


    }

    void Jump(){
        // if (Input.GetKeyDown(KeyCode.Space))
        // { 
        //     if(is_grounded){
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
    //}}
    }
}
