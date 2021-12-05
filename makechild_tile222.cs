using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makechild_tile222 : MonoBehaviour
{
   public static bool isOnMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit2D(Collision2D col){
        if(col.gameObject.CompareTag("player")){
                isOnMoving = false;
        }
    }

   private void OnCollisionEnter2D(Collision2D col){
                if(col.gameObject.CompareTag("player")){
                isOnMoving = true;
        }
   }
}
