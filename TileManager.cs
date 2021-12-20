using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] tilePrefabs;
    public float xSpawn = 0;    
    public float tileLength = 23;
    public int numberoftiles = 1;
    void Start()
    {
         //int rand = Random.Range(0,tilePrefabs.Length);
        //SpawnTile(0);
        //SpawnTile(1);
        //SpawnTile(4);

        for(int i=0; i < numberoftiles ; i++){
            SpawnTile(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTile(int tileindex){
        Instantiate(tilePrefabs[tileindex], new Vector2( xSpawn,0), transform.rotation);
        //Instantiate(objects[rand], transform.position, Quaternion.identity);
        xSpawn += tileLength;
    }
}
