using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuscorescript : MonoBehaviour
{
    
    public Text healthtext;
    public Text TotalScoreTxt;
    public Text HighestScoreTxt;
    int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 10+PlayerPrefs.GetInt("ExtraHealth", 0);
        healthtext.text = "Health: " + health.ToString();
        TotalScoreTxt.text = "TotalScore: " + PlayerPrefs.GetInt("TotalScore", 0).ToString();
        HighestScoreTxt.text = "Highest Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        health = 10+PlayerPrefs.GetInt("ExtraHealth", 0);
        healthtext.text = "Health: " + health.ToString();
        TotalScoreTxt.text = "TotalScore: " + PlayerPrefs.GetInt("TotalScore", 0).ToString();
        HighestScoreTxt.text = "Highest Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        
    }
}
