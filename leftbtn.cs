using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftbtn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        Vector3 characterScale = player.transform.localScale;
        var movement = Input.GetAxis("Horizontal");
        player.transform.position += new Vector3(movement,0,0) * Time.deltaTime * player2dcontroller.MovementSpeed;
        
        if(Input.GetAxis("Horizontal") < 0){
            characterScale.x = -0.3f;
            
           player2dcontroller.faceright = false;
        }
        player.transform.localScale = characterScale;
    }
}
