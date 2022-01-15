using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolOnOff : MonoBehaviour
{
    public static int ismute = 0;
    public GameObject volon;
    public GameObject voloff;
    // Start is called before the first frame update
    void Start()
    {
       ismute =0; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VolumeOn(){
        ismute = 0;
        PlayerPrefs.SetInt("mute", ismute);
        volon.SetActive(true);
        voloff.SetActive(false);
        AudioListener.pause = false;
    }

    public void VolumeOff(){
        ismute = 1;
        PlayerPrefs.SetInt("mute", ismute);
        volon.SetActive(false);
        voloff.SetActive(true);
        AudioListener.pause = true;
    }
}
