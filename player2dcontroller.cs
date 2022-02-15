using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;
//GetKeyDown(KeyCode.C)

public class player2dcontroller : MonoBehaviour
{
    public static float timer = 1.0f;
    public bool blink = false;

    public GameObject weapontoright;
    public GameObject weapontoleft;
    Vector2 weaponpos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;
    public bool faceright = true;
    

    public float MovementSpeed = 6;
    public float JumpForce = 8;
    bool is_grounded;
    public Transform groundcheck;
    public LayerMask groundlayer;
    private SpriteRenderer colorrenderer_player;
    public SpriteRenderer colorrenderer_specialtile;
    public Sprite gamechar2;
    public Sprite gamechar3;
    public Sprite gamechar4;

    public Sprite tile1;
    public Sprite tile2;
    public Sprite tile3;
    public GameObject colorchangertile;
    
    public GameObject tile111; 
    public GameObject tile222; 
    public GameObject tile333; 
    
     private BoxCollider2D collider_player;
    private void Start()
    {
        colorrenderer_player = GetComponent<SpriteRenderer>();
        collider_player = GetComponent<BoxCollider2D>();
        colorrenderer_specialtile = colorchangertile.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    public void Update()
    {

        if(blink){
            timer -= Time.deltaTime;
            if(timer < 0)
        {
            blink = false;
            colorrenderer_player.color = new Color(1f,1f,1f,1f);
            timer = 1.0f;
        }
        }


        Vector3 characterScale = transform.localScale;

        is_grounded = Physics2D.OverlapCircle(groundcheck.position, 2.0f, groundlayer);
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        { 
            if(is_grounded){
               // collider_player.enabled = false;
        Jump();
        }}
        var movement = CrossPlatformInputManager.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;
        
        if(CrossPlatformInputManager.GetAxis("Horizontal") < 0){
            characterScale.x = -0.3f;
            
            faceright = false;
        }
        if(CrossPlatformInputManager.GetAxis("Horizontal") > 0){
            characterScale.x = 0.3f;
            
            faceright = true;
        }

        // if (Input.GetKeyDown(KeyCode.Space))
        // { 
        //     if(is_grounded){
        //        // collider_player.enabled = false;
        // Jump();
        // }}
        // var movement = Input.GetAxis("Horizontal");
        // transform.position += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;
        
        // if(Input.GetAxis("Horizontal") < 0){
        //     characterScale.x = -0.3f;
            
        //     faceright = false;
        // }
        // if(Input.GetAxis("Horizontal") > 0){
        //     characterScale.x = 0.3f;
            
        //     faceright = true;
        // }

        transform.localScale = characterScale;

        if(transform.position.y < -6){
            // GameController.isGameOver = true;
            //Destroy(gameObject);
            
            SceneManager.LoadScene("EndGame");
        }

        


        if ((CrossPlatformInputManager.GetButtonDown("Fire")) && (Time.time > nextFire)){
            nextFire = Time.time + fireRate;
        FindObjectOfType<AudioManager>().Play("Weapon");
            fire();
        }


        // if ((Input.GetKeyDown(KeyCode.C)) && (Time.time > nextFire)){
        //     nextFire = Time.time + fireRate;
        //     FindObjectOfType<AudioManager>().Play("Weapon");
        //     fire();
        // }

    }

    void OnCollisionStay2D(Collision2D col){
        // Debug.Log("Done");
        if((col.gameObject.CompareTag("tile1")) || (col.gameObject.CompareTag("tile11")) || (col.gameObject.CompareTag("tile111")) || (col.gameObject.CompareTag("tile1111")) ){

                if(colorrenderer_player.sprite == gamechar2){
                collider_player.enabled = true;
            }
            else{
                collider_player.enabled = false;
              
            }
           
        }

        if((col.gameObject.CompareTag("tile2")) || (col.gameObject.CompareTag("tile22")) || (col.gameObject.CompareTag("tile222")) || (col.gameObject.CompareTag("tile2222"))){
            if(colorrenderer_player.sprite == gamechar3){
                collider_player.enabled = true;
            }
            else{
                collider_player.enabled = false;
            }
        }

        if((col.gameObject.CompareTag("tile3")) || (col.gameObject.CompareTag("tile33")) || (col.gameObject.CompareTag("tile333")) || (col.gameObject.CompareTag("tile3333"))){
            if(colorrenderer_player.sprite == gamechar4){
                collider_player.enabled = true;
            }
            else{
                collider_player.enabled = false;
            }
        }


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

        if((col.gameObject.CompareTag("spike")) || (col.gameObject.CompareTag("enemy"))){
            colorrenderer_player.color = new Color(1f,1f,1f,.5f);
            blink = true;
            FindObjectOfType<AudioManager>().Play("Hurt");
        }


    }

   public void Jump(){
        // if (Input.GetKeyDown(KeyCode.Space))
        // { 
        //     if(is_grounded){
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
    //}}
    }
    // public void moveleftright(){

    // }

   public void fire(){
        weaponpos = transform.position;
        if(faceright){
            weaponpos += new Vector2(+1f, 0.2f);
            Instantiate(weapontoright, weaponpos, Quaternion.identity);
        }
        else{
            weaponpos += new Vector2(-1f, 0.2f);
            Instantiate(weapontoleft, weaponpos, Quaternion.identity);
        }
    }
}
