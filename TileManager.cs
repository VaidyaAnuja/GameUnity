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
    public Transform playerTransform;
    private List<GameObject> activetiles =new List<GameObject>();
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
        if(playerTransform.position.x > xSpawn - (numberoftiles*tileLength)){
            SpawnTile(0);
            DeleteTile();
        }
        
    }

    public void SpawnTile(int tileindex){
       GameObject go = Instantiate(tilePrefabs[tileindex], new Vector2( xSpawn,0), transform.rotation);
        //Instantiate(objects[rand], transform.position, Quaternion.identity);
        activetiles.Add(go);
        xSpawn += tileLength;
    }
    private void DeleteTile(){
        Destroy(activetiles[0]);
        activetiles.RemoveAt(0);
    }
}
