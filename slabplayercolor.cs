
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slabplayercolor : MonoBehaviour
{
    public SpriteRenderer colorrenderer_player;
  public GameObject player;
  public Sprite gamechar2;
  public Sprite tile1;
    public Sprite gamechar3;
  public Sprite tile2;
    public Sprite gamechar4;
  public Sprite tile3;
//   public Renderer colorrenderer_tile;
private SpriteRenderer colorrenderer_tile;
  //public GameObject tile;
    private BoxCollider2D collider_tile;

    // Start is called before the first frame update
    void Start()
    {
        colorrenderer_player = player.GetComponent<SpriteRenderer>();
        colorrenderer_tile = GetComponent<SpriteRenderer>();
        collider_tile = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if((colorrenderer_player.sprite == gamechar2) && (colorrenderer_tile.sprite == tile1)){
            collider_tile.enabled = true;
     }
     else if((colorrenderer_player.sprite == gamechar3) && (colorrenderer_tile.sprite == tile2)){
            collider_tile.enabled = true;
     }
     else if((colorrenderer_player.sprite == gamechar4) && (colorrenderer_tile.sprite == tile3)){
            collider_tile.enabled = true;
     }
       else {
           collider_tile.enabled = false;
       }
}}
