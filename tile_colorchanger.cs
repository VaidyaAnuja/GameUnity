using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile_colorchanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public int i=0;
    public float timeLeft = 3.0f;
    public float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       // timer -= Time.deltaTime;
        if(timer<=0){
        timeLeft -= Time.deltaTime;
        if(timeLeft < 0)
        {
            if(i>2){
                i=0;
            }
            spriteRenderer.sprite = spriteArray[i];
            i++;
            timeLeft = 3.0f;
        }}

        if(timer > 0){
            timer -= Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.V)){
            timer = 5.0f;
        }
}
    
}
