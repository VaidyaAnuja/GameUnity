using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapcolorofplayer : MonoBehaviour {

public SpriteRenderer spriteRenderer;
//public Sprite newSprite;
public GameObject player;
public Sprite[] spriteArray;

//[SerializeField] private Color newColor;

public int i=0;

private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

private void Update(){
if(Input.GetKeyDown(KeyCode.X))
        {
            if(i>2){
                i=0;
            }
            spriteRenderer.sprite = spriteArray[i];
            i++;
            //  spriteRenderer.sprite = newSprite; 
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 0.6f), ForceMode2D.Impulse);
        }
}


}