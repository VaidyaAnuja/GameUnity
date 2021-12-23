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
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        healthtext.text = "x " + swapcolorofplayer.health.ToString();
        TimerText.text = "Timer: " + swapcolorofplayer.timer.ToString();
        healthtextforenemy.text = "x " + enemycollidendecreasehealth.enemyhealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        healthtext.text = "x " + swapcolorofplayer.health.ToString();
        healthtextforenemy.text = "x " + enemycollidendecreasehealth.enemyhealth.ToString();
        TimerText.text = "Timer: " + swapcolorofplayer.timer.ToString();
    }
}
