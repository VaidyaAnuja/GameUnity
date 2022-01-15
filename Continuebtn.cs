using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class Continuebtn : MonoBehaviour
{
    public GameObject THIS;
    public GameObject NEXT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Continue(){
        NEXT.SetActive(true);
        THIS.SetActive(false);
        
    }

    public void skip(){
        SceneManager.LoadScene("Menu");
    }
}
