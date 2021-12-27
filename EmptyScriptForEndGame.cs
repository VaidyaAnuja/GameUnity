using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmptyScriptForEndGame : MonoBehaviour
{
    public Text ScoreTxt;
    public Text HighScoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        ScoreTxt.text = "Score: " + displayhealth.score.ToString();
        if(displayhealth.score > PlayerPrefs.GetInt("HighScore", 0)){
        PlayerPrefs.SetInt("HighScore", displayhealth.score);
        }
        HighScoreTxt.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
