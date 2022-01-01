using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmptyScriptForEndGame : MonoBehaviour
{
    public Text ScoreTxt;
    public Text HighScoreTxt;
    public int TotalScore;
    public Text TotalScoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        ScoreTxt.text = "Score: " + displayhealth.score.ToString();
        TotalScore = PlayerPrefs.GetInt("TotalScore", 0) + displayhealth.score;
        PlayerPrefs.SetInt("TotalScore", TotalScore);
        if(displayhealth.score > PlayerPrefs.GetInt("HighScore", 0)){
        PlayerPrefs.SetInt("HighScore", displayhealth.score);
        }
        TotalScoreTxt.text = "Total Score: " + PlayerPrefs.GetInt("TotalScore", 0).ToString();
        HighScoreTxt.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    
    
    // Update is called once per frame
    void Update()
    {
       
    }
}
