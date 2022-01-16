using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class swapcolorofplayer : MonoBehaviour {

public SpriteRenderer spriteRenderer;
//public Sprite newSprite;
public GameObject player;
public Sprite[] spriteArray;
public static int health;

public static string whichcolor;
public static float timer = 0.0f;
public static int count = 1;

//[SerializeField] private Color newColor;

public int i=0;

private void Start()
    {
        health = 10 + PlayerPrefs.GetInt("ExtraHealth", 0);
        PlayerPrefs.SetInt("ExtraHealth", 0);
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        whichcolor = "green";
    }

private void Update(){
if(Input.GetKeyDown(KeyCode.X))
        {
            if(i>2){
                i=0;
            }
            if(i==0){
                whichcolor = "pink";
            }

            if(i==1){
                whichcolor = "violet";
            }

            if(i==2){
                whichcolor = "green";
            }
            spriteRenderer.sprite = spriteArray[i];
            i++;
            //  spriteRenderer.sprite = newSprite; 
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 0.6f), ForceMode2D.Impulse);
        }



        // if(CrossPlatformInputManager.GetButtonDown("Color"))
        // {
        //     if(i>2){
        //         i=0;
        //     }
        //     if(i==0){
        //         whichcolor = "pink";
        //     }

        //     if(i==1){
        //         whichcolor = "violet";
        //     }

        //     if(i==2){
        //         whichcolor = "green";
        //     }
        //     spriteRenderer.sprite = spriteArray[i];
        //     i++;
        //     //  spriteRenderer.sprite = newSprite; 
        //     gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 0.6f), ForceMode2D.Impulse);
        // }

if(health == 0){
   // Destroy(gameObject);
   
     SceneManager.LoadScene("EndGame");
}

if(timer > 0){
            swapcolorofplayer.timer -= Time.deltaTime;
}

if(Input.GetKeyDown(KeyCode.V)){
            count = count + 1;
            timer = 8.0f;
            // if(enemycollidendecreasehealth.enemyhealth==0){
            //     enemycollidendecreasehealth.enemyhealth = 2;
            // }
            enemycollidendecreasehealth.enemyhealth = enemycollidendecreasehealth.enemyhealth+2;
            
        }

        // if(CrossPlatformInputManager.GetButtonDown("Snooze")){
        //     count = count + 1;
        //     timer = 8.0f;
        //     // if(enemycollidendecreasehealth.enemyhealth==0){
        //     //     enemycollidendecreasehealth.enemyhealth = 2;
        //     // }
        //     enemycollidendecreasehealth.enemyhealth = enemycollidendecreasehealth.enemyhealth+2;
            
        // }
}


}