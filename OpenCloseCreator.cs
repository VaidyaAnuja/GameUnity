using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseCreator : MonoBehaviour
{
    public static bool AboutOpen = false;
    public GameObject AboutCreator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void About(){
        AboutCreator.SetActive(true);
        Time.timeScale = 0f;
        AboutOpen = true;
    }

    public void AboutClose(){
        AboutCreator.SetActive(false);
        Time.timeScale = 1f;
        AboutOpen = false;
    }
}
