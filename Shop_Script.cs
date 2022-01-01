using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop_Script : MonoBehaviour
{
    public int Score;
    public int health;
    public Text TotalScoreTxt;
    public GameObject closeshop;
    // Start is called before the first frame update
    void Start()
    {
        TotalScoreTxt.text = "Total Score: " + PlayerPrefs.GetInt("TotalScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
       // TotalScoreTxt.text = "Total Score: " + PlayerPrefs.GetInt("TotalScore", 0).ToString();
    }
    public void Buy(){
        Score = PlayerPrefs.GetInt("TotalScore", 0) - 20;
        PlayerPrefs.SetInt("TotalScore", Score);
        health = PlayerPrefs.GetInt("ExtraHealth", 0) + 1;
        PlayerPrefs.SetInt("ExtraHealth", health);
        closeshop.SetActive(false);
        Time.timeScale = 1f;
    }
}
