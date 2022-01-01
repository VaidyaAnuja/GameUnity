using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseShop : MonoBehaviour
{
    public static bool ShopOpen = false;
    public GameObject Shop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Shop_Open(){
        Shop.SetActive(true);
        Time.timeScale = 0f;
        ShopOpen = true;
    }

    public void Shop_Close(){
        Shop.SetActive(false);
        Time.timeScale = 1f;
        ShopOpen = false;
    }
}
