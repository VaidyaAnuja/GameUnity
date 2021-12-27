using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class RestartAndMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(CrossPlatformInputManager.GetButtonDown("Restart")){
        //     Time.timeScale = 1f;
        //     SceneManager.LoadScene("Game");
        // }

        // // if(CrossPlatformInputManager.GetButtonDown("Quit")){
        // //          Application.Quit();
        // // }

        // if(CrossPlatformInputManager.GetButtonDown("Menu")){
        //          SceneManager.LoadScene("Menu");
        // }
    }

    public void Restart(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }

    public void Menu(){
        SceneManager.LoadScene("Menu");
    }
}
