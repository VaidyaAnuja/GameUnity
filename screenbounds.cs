using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenbounds : MonoBehaviour
{
     private Vector2 screenBounds;
    //public Camera maincam;

    // Use this for initialization
    void Start () {
        //maincam = GameObject.Find("Main Camera").GetComponent<Camera>();
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update () {
        //Debug.Log(maincam.transform.position);
        //Debug. Log(screenBounds);
        float cameraxpos = Camera.main.transform.position.x;
        Debug.Log(cameraxpos);
        if(transform.position.x < cameraxpos - 10){
            Destroy(this.gameObject);
       }
    }
}
