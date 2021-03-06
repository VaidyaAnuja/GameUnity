using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class pausescript : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Escape)){
        //     if (GameIsPaused)
        //     {
        //         Resume();
        //     }
        //     else{
        //         Pause();
        //     }
        // }

        if(CrossPlatformInputManager.GetButtonDown("Pause")){
            Pause();
        }

        if(CrossPlatformInputManager.GetButtonDown("Resume")){
            Resume();
        }

        // if(CrossPlatformInputManager.GetButtonDown("Restart")){
        //     SceneManager.LoadScene("Game");
        // }

        // // if(CrossPlatformInputManager.GetButtonDown("Quit")){
        // //          Application.Quit();
        // // }

        // if(CrossPlatformInputManager.GetButtonDown("Menu")){
        //          SceneManager.LoadScene("Menu");
        // }
        
    }

    void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
