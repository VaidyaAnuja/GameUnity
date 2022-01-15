using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumeonoff : MonoBehaviour
{
    public GameObject volon;
    public GameObject voloff;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("mute", 0)==0){
            volon.SetActive(true);
        voloff.SetActive(false);
        }
        else{
            volon.SetActive(false);
        voloff.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("mute", 0)==0){
            volon.SetActive(true);
        voloff.SetActive(false);
        }
        else{
            volon.SetActive(false);
        voloff.SetActive(true);
        }
    }
}
