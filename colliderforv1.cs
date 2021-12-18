using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderforv1 : MonoBehaviour
{
    private BoxCollider2D colider_v1;
   // private SpriteRenderer color_v1;
    public float after = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        colider_v1 = GetComponent<BoxCollider2D>();
       // color_v1 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (colider_v1.enabled == false){
            after -= Time.deltaTime;
                if (after < 0)
                {
                    colider_v1.enabled = true;
                    after = 1.5f;
                }}
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("player") ){
            if(swapcolorofplayer.whichcolor == "green"){
                colider_v1.enabled = true;
            }
            else{
                colider_v1.enabled = false;
            }
        }

        if(col.gameObject.CompareTag("weapon") ){
        
             colider_v1.enabled = false;
        }
    }
}
