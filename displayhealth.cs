using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayhealth : MonoBehaviour
{
    public Text healthtext;
    // Start is called before the first frame update
    void Start()
    {
        healthtext.text = " x " + swapcolorofplayer.health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        healthtext.text = " x " + swapcolorofplayer.health.ToString();
    }
}
