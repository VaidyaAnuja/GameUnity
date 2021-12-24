using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EverythingabtScore : MonoBehaviour
{
    public static int lastscoreatendgame;
    public static int highest_score = 0;
    public static int add_allscores = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lastscoreatendgame>highest_score){
            lastscoreatendgame = highest_score;
        }
        add_allscores = add_allscores + lastscoreatendgame;
    }
}
