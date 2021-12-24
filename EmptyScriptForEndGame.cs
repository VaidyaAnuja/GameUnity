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
        ScoreTxt.text = "Score: " + EverythingabtScore.lastscoreatendgame.ToString();
         HighScoreTxt.text = "Highest Score: " + EverythingabtScore.highest_score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
