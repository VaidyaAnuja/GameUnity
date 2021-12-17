using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    public float dirX, movespeed = 2f;
    public bool moveleft = false;
    float currentpos = 0f;
   // public static bool isOnMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        currentpos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 characterScale = transform.localScale;
        if (transform.position.x >= currentpos){
            moveleft = true;
        }

        if (transform.position.x <= currentpos-2.5){
            moveleft = false;
        }

        if(moveleft){
            transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime , transform.position.y);
            characterScale.x = 0.7447402f;
        }

        else{
            transform.position = new Vector2(transform.position.x + movespeed * Time.deltaTime , transform.position.y);
            characterScale.x = -0.7447402f;
        }
        transform.localScale = characterScale;
    }

}
