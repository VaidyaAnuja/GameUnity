using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollider : MonoBehaviour
{
    private CircleCollider2D collider_coin;
    public float after = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        collider_coin = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (collider_coin.enabled == false){
            after -= Time.deltaTime;
                if (after < 0)
                {
                    collider_coin.enabled = true;
                    after = 1.5f;
                }}
    }

    void OnCollisionEnter2D(Collision2D col){
            if(col.gameObject.CompareTag("player") ){
                //collider_coin.enabled = false;
                displayhealth.score = displayhealth.score + 1;
                //Debug.Log(displayhealth.score);
                Destroy(this.gameObject);
    }

    else{
        collider_coin.enabled = false;
    }
}}
