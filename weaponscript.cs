using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponscript : MonoBehaviour
{
    public float velx = 5f;
    public float vely = 0f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2 (velx,vely);
        
    }
    void OnCollisionEnter2D (Collision2D col){
        if((col.gameObject.CompareTag("player")) || (col.gameObject.CompareTag("vertical_block_1")) || (col.gameObject.CompareTag("vertical_block_2")) || (col.gameObject.CompareTag("vertical_block_3")) || (col.gameObject.CompareTag("vertical_colorchanger"))){

        }
        else{
        Destroy(gameObject);}
    }
}
