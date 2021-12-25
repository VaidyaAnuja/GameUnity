using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycollidendecreasehealth : MonoBehaviour
{
    public static float timeLeft = 1.0f;
    public static int enemyhealth;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyhealth = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<-6){
            enemyhealth = 2*swapcolorofplayer.count;
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
        enemyhealth = enemyhealth-1;
        if(enemyhealth<=0){
          Destroy(gameObject);
          enemyhealth = 2*swapcolorofplayer.count;
        }
    }}
}
