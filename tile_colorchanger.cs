using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile_colorchanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public int i=0;
    //public float time_enable = 0.0f;
    public static float timeLeft = 4.0f;
    //public static float timer = 0.0f;
    public static string color;
   // private BoxCollider2D collider_tile;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        color = "green";
        
       // collider_tile = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (collider_tile.enabled == false){
        //     time_enable -= Time.deltaTime;
        //         if (time_enable < 0)
        //         {
        //             collider_tile.enabled = true;
        //             time_enable = 0.0f;
        //         }}

       // timer -= Time.deltaTime;
        if(swapcolorofplayer.timer<=0){
        timeLeft -= Time.deltaTime;
        if(timeLeft < 0)
        {
            if(i>2){
                i=0;
            }
            if(i==0){
                color = "pink";
            }

            if(i==1){
                color = "green";
            }

            if(i==2){
                color = "violet";
            }
            spriteRenderer.sprite = spriteArray[i];
            i++;
            timeLeft = 4.0f;

            // if((swapcolorofplayer.whichcolor == "green") && (color == "green")){
            //     collider_tile.enabled = true;
            // }
            // else if((swapcolorofplayer.whichcolor == "pink") && (color == "pink")){
            //     collider_tile.enabled = true;
            // }
            // else if((swapcolorofplayer.whichcolor == "violet") && (color == "violet")){
            //     collider_tile.enabled = true;
            // }
            // else{
            //     collider_tile.enabled = false;
            // }
        }}

        // if(swapcolorofplayer.timer > 0){
        //     swapcolorofplayer.timer -= Time.deltaTime;
        // }

        // if(Input.GetKeyDown(KeyCode.V)){
        //     swapcolorofplayer.timer = 8.0f;
        // }
}
    
}
