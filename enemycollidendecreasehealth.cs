using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycollidendecreasehealth : MonoBehaviour
{
    public static float timeLeft = 1.0f;
    public static float timer = 1.0f;
    public bool blink = false;
    public static int enemyhealth = 2;
    public SpriteRenderer spriteRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
       // enemyhealth = 2;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<-10){
            enemyhealth = 2*swapcolorofplayer.count;
        }

        if(blink){
            timer -= Time.deltaTime;
            if(timer < 0)
        {
            blink = false;
            spriteRenderer.color = new Color(1f,1f,1f,1f);
            timer = 1.0f;
        }
        }
    }
    void OnCollisionStay2D(Collision2D col){

        if(col.gameObject.name == "player"){
            timeLeft -= Time.deltaTime;
             if(timeLeft < 0)
        {
            swapcolorofplayer.health = swapcolorofplayer.health - 1;
            timeLeft = 1.0f;
        }
        
    }

  
}

void OnCollisionEnter2D (Collision2D col){
    if((col.gameObject.CompareTag("weapon"))){
        spriteRenderer.color = new Color(1f,1f,1f,.5f);
        blink = true;
        enemyhealth = enemyhealth-1;
        

        if(enemyhealth<=0){
          Destroy(gameObject);
          enemyhealth = 2*swapcolorofplayer.count;
        }
    }}
}
