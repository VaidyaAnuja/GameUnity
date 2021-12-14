using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderforv3 : MonoBehaviour
{
    private BoxCollider2D colider_v3;
   // private SpriteRenderer color_v1;
    public float after = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        colider_v3 = GetComponent<BoxCollider2D>();
       // color_v1 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (colider_v3.enabled == false){
            after -= Time.deltaTime;
                if (after < 0)
                {
                    colider_v3.enabled = true;
                    after = 1.5f;
                }}
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("player") ){
            if(swapcolorofplayer.whichcolor == "violet"){
                colider_v3.enabled = true;
            }
            else{
                colider_v3.enabled = false;
            }
        }
    }
}
