using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderforverticalcolorchanger : MonoBehaviour
{
    private BoxCollider2D colider_colorchange;
    public float after = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        colider_colorchange = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (colider_colorchange.enabled == false){
            after -= Time.deltaTime;
                if (after < 0)
                {
                    colider_colorchange.enabled = true;
                    after = 1.5f;
                }}
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("player") ){
        

            if((swapcolorofplayer.whichcolor == "green") 
            && 
            (colorchangerforvertical.color == "green")
            ){
               // Debug.Log("Green");
                colider_colorchange.enabled = true;
            }
        else if((swapcolorofplayer.whichcolor == "pink") 
        && 
        (colorchangerforvertical.color == "pink")
        ){
             //Debug.Log("Pink");
                colider_colorchange.enabled = true;
            }
        else if((swapcolorofplayer.whichcolor == "violet") 
        && 
        (colorchangerforvertical.color == "violet")
        ){
            // Debug.Log("Violet");
                colider_colorchange.enabled = true;
            }
            else{
                colider_colorchange.enabled = false;
            }

        }
    }
}
