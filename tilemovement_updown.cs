using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilemovement_updown : MonoBehaviour
{
    public float dirY, movespeed = 2f;
    public bool moveup = false;
    float currentpos = 0f;
   // public static bool isOnMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        currentpos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        // if(isOnMoving){
        //     myPlayer.transform.SetParent(this.transform);
        // }
        // if(isOnMoving ==false ){
        //     myPlayer.transform.SetParent(null);
        // }
        if (transform.position.y <= currentpos){
            moveup = true;
        }

        if (transform.position.y >= currentpos+5){
            moveup = false;
        }

        if(moveup){
            transform.position = new Vector2(transform.position.x , transform.position.y + movespeed * Time.deltaTime);
        }

        else{
            transform.position = new Vector2(transform.position.x , transform.position.y - movespeed * Time.deltaTime);
        }
    }

//     private void OnCollisionExit2D(Collision2D col){
//         if(col.gameObject.CompareTag("player")){
//                 isOnMoving = false;
//         }
//     }

//    private void OnCollisionEnter2D(Collision2D col){
//                 if(col.gameObject.CompareTag("player")){
//                 isOnMoving = true;
//         }
//    }

}
