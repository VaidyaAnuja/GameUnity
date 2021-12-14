using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilemanagervertical : MonoBehaviour
{
     public GameObject[] tilePrefabs;
    public float xSpawn = 0;    
    public float tileLength = 40;
    void Start()
    {
         //int rand = Random.Range(0,tilePrefabs.Length);
        SpawnTile(0);
        //SpawnTile(1);
        //SpawnTile(4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTile(int tileindex){
        Instantiate(tilePrefabs[tileindex], transform.position * xSpawn, transform.rotation);
        //Instantiate(objects[rand], transform.position, Quaternion.identity);
        xSpawn += tileLength;
    }
}
