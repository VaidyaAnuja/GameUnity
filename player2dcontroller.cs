using UnityEngine;
using UnityEngine.SceneManagement;

public class player2dcontroller : MonoBehaviour
{
    public float MovementSpeed = 3;
    public float JumpForce = 8;
    bool is_grounded;
    public Transform groundcheck;
    public LayerMask groundlayer;
    private SpriteRenderer colorrenderer_player;
    public SpriteRenderer colorrenderer_specialtile;

    //public SpriteRenderer colorrenderer_specialvertical;
    public Sprite gamechar2;
    public Sprite gamechar3;
    public Sprite gamechar4;

    public Sprite tile1;
    public Sprite tile2;
    public Sprite tile3;

    // public Sprite verical1;
    // public Sprite vertical2;
    // public Sprite vertical3;
    // public GameObject v1; 
    // public GameObject v2; 
    // public GameObject v3; 
    public GameObject colorchangertile;
    //public GameObject colorchangervertical;
    
    public GameObject tile111; 
    public GameObject tile222; 
    public GameObject tile333; 
    
     private BoxCollider2D collider_player;
    //  public BoxCollider2D collider_v1;
    //  public BoxCollider2D collider_v2;
    //  public BoxCollider2D collider_v3;

    //  public BoxCollider2D collider_specialvertical;

     
     //public float after = 5.0f;
    // Start is called before the first frame update
    private void Start()
    {
        colorrenderer_player = GetComponent<SpriteRenderer>();
        collider_player = GetComponent<BoxCollider2D>();
        colorrenderer_specialtile = colorchangertile.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 characterScale = transform.localScale;

        is_grounded = Physics2D.OverlapCircle(groundcheck.position, 2.0f, groundlayer);
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            if(is_grounded){
               // collider_player.enabled = false;
        Jump();
        }}
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;
        
        if(Input.GetAxis("Horizontal") < 0){
            characterScale.x = -0.3f;
        }
        if(Input.GetAxis("Horizontal") > 0){
            characterScale.x = 0.3f;
        }

        transform.localScale = characterScale;

        if(transform.position.y < -6){
            // GameController.isGameOver = true;
            SceneManager.LoadScene("EndGame");
        }

        
        if(makechild_tile111.isOnMoving){
            this.transform.SetParent(tile111.transform);
        }
        if((makechild_tile111.isOnMoving ==false) && (makechild_tile222.isOnMoving ==false) && (makechild_tile333.isOnMoving ==false) ){
            this.transform.SetParent(null);
        }

        if(makechild_tile222.isOnMoving){
            this.transform.SetParent(tile222.transform);
        }

        if(makechild_tile333.isOnMoving){
            this.transform.SetParent(tile333.transform);
        }

    }

    void OnCollisionStay2D(Collision2D col){
        // Debug.Log("Done");
        if((col.gameObject.CompareTag("tile1")) || (col.gameObject.CompareTag("tile11")) || (col.gameObject.CompareTag("tile111")) ){

                if(colorrenderer_player.sprite == gamechar2){
                collider_player.enabled = true;
            }
            else{
                collider_player.enabled = false;
              
            }
           
        }

        if((col.gameObject.CompareTag("tile2")) || (col.gameObject.CompareTag("tile22")) || (col.gameObject.CompareTag("tile222"))){
            if(colorrenderer_player.sprite == gamechar3){
                collider_player.enabled = true;
            }
            else{
                collider_player.enabled = false;
            }
        }

        if((col.gameObject.CompareTag("tile3")) || (col.gameObject.CompareTag("tile33")) || (col.gameObject.CompareTag("tile333"))){
            if(colorrenderer_player.sprite == gamechar4){
                collider_player.enabled = true;
            }
            else{
                collider_player.enabled = false;
            }
        }

        // if(col.gameObject.CompareTag("tilecolorchanger")){
            
        //     if((colorrenderer_player.sprite == gamechar2) && (colorrenderer_specialtile.sprite == tile1)){
        //         collider_player.enabled = true;
                
        //     }

        //     else if((colorrenderer_player.sprite == gamechar3) && (colorrenderer_specialtile.sprite == tile2)){
        //         collider_player.enabled = true;
        //         Debug.Log("Okay");
        //     }

        //     else if((colorrenderer_player.sprite == gamechar4) && (colorrenderer_specialtile.sprite == tile3)){
        //         collider_player.enabled = true;
        //     }

        //     else{
        //         collider_player.enabled = false;
        //     }
        // }

        if(col.gameObject.CompareTag("tilecolorchanger")){
           
            
            if((colorrenderer_player.sprite == gamechar2)  && 
            (tile_colorchanger.color == "green")
            ){
                collider_player.enabled = true;
                 
            }

            else if((colorrenderer_player.sprite == gamechar3) && 
            (tile_colorchanger.color == "pink")
            ){
                collider_player.enabled = true;
                
            }

            else if((colorrenderer_player.sprite == gamechar4) && 
            (tile_colorchanger.color == "violet")
            ){
                collider_player.enabled = true;
                 
            }

            else{
                collider_player.enabled = false;
            }
        }

//         if(col.gameObject.CompareTag("vertical_colorchanger")){
//             if((colorrenderer_player.sprite == gamechar2) && (colorrenderer_specialvertical.sprite == verical1)){
//                 collider_specialvertical.enabled = true;
//             }

//             else if((colorrenderer_player.sprite == gamechar3) && (colorrenderer_specialvertical.sprite == vertical2)){
//                 collider_specialvertical.enabled = true;
//             }

//             else if((colorrenderer_player.sprite == gamechar4) && (colorrenderer_specialvertical.sprite == vertical3)){
//                 collider_specialvertical.enabled = true;
//             }

//             else{
//                 collider_specialvertical.enabled = false;
//             }
//         }

       

// if(col.gameObject.CompareTag("vertical_block_1")){
//             if(colorrenderer_player.sprite == gamechar2){
//                 collider_v1.enabled = true;
//             }
//             else{
//                 collider_v1.enabled = false;
                 
//             }
//         }

//         if(col.gameObject.CompareTag("vertical_block_2")){
//             if(colorrenderer_player.sprite == gamechar3){
//                 collider_v2.enabled = true;
//             }
//             else{
//                 collider_v2.enabled = false;
                 
//             }
//         }

//         if(col.gameObject.CompareTag("vertical_block_3")){
//             if(colorrenderer_player.sprite == gamechar4){
//                 collider_v3.enabled = true;
//             }
//             else{
//                 collider_v3.enabled = false;
                 
//             }
//         }


    }

    void Jump(){
        // if (Input.GetKeyDown(KeyCode.Space))
        // { 
        //     if(is_grounded){
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
    //}}
    }
}
