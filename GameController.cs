
using UnityEngine;


public class GameController : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    private void Awake(){
        isGameOver = false;
    }
    void Start(){}

    void Update(){
        if(isGameOver){
            gameOverScreen.SetActive(true);
        }
    }
    
}
