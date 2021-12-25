using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayhealth : MonoBehaviour
{
    public static int score;
    public Text healthtext;
    public Text healthtextforenemy;
    public Text TimerText;
    public Text ScoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        healthtext.text = "x " + swapcolorofplayer.health.ToString();
        ScoreTxt.text = ": " + score.ToString();
        TimerText.text = ": " + swapcolorofplayer.timer.ToString();
        healthtextforenemy.text = "x " + enemycollidendecreasehealth.enemyhealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreTxt.text = ": " + score.ToString();
        healthtext.text = "x " + swapcolorofplayer.health.ToString();
        healthtextforenemy.text = "x " + enemycollidendecreasehealth.enemyhealth.ToString();
        TimerText.text = ": " + swapcolorofplayer.timer.ToString();
    }
}
