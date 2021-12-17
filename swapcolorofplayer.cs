using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class swapcolorofplayer : MonoBehaviour {

public SpriteRenderer spriteRenderer;
//public Sprite newSprite;
public GameObject player;
public Sprite[] spriteArray;
public static int health = 10;
public static string whichcolor;

//[SerializeField] private Color newColor;

public int i=0;

private void Start()
    {
        health = 10;
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

if(health == 0){
   // Destroy(gameObject);
     SceneManager.LoadScene("EndGame");
}
}


}