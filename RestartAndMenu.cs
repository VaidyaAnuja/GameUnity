using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class RestartAndMenu : MonoBehaviour
{
    public int TotalScore;
    // public static bool AboutOpen = false;
    // public GameObject AboutCreator;
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

    public void Play(){
        SceneManager.LoadScene("Game");
    }

    public void HowTo(){
        SceneManager.LoadScene("Storyboard");
    }

    // public void About(){
    //     AboutCreator.SetActive(true);
    //     Time.timeScale = 0f;
    //     AboutOpen = true;
    // }

    // public void AboutClose(){
    //     AboutCreator.SetActive(false);
    //     Time.timeScale = 1f;
    //     AboutOpen = false;
    // }

    public void Quit(){
        Application.Quit();
    }

    public void MenuFromGame(){
        TotalScore = PlayerPrefs.GetInt("TotalScore", 0) + displayhealth.score;
        PlayerPrefs.SetInt("TotalScore", TotalScore);
        SceneManager.LoadScene("Menu");
    }


}
