using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridController : MonoBehaviour {

    private GameObject mainGrid;
    private BoundsInt bounds;

    public Tilemap tileMap;
    public TileBase[] allTiles;
    

    // Use this for initialization
    void Start () {
        
        mainGrid = GameObject.Find("MapGrid");
        tileMap = mainGrid.GetComponentInChildren<Tilemap>();

        bounds = tileMap.cellBounds;
        allTiles = tileMap.GetTilesBlock(bounds);

        /*
        for (int x = 0; x < bounds.size.x; x++)
        {
            for (int y = 0; y < bounds.size.y; y++)
            {
                TileBase tile = GetMapTile(x, y);
                if (tile != null)
                {
                    Debug.Log("x:" + x + " y:" + y + " tile:" + tile.name);
                }
                else
                {
                    Debug.Log("x:" + x + " y:" + y + " tile: (null)");
                }
            }
        }
        */

    }

    public TileBase GetMapTile(int x, int y)
    {
        TileBase tile = allTiles[x + y * bounds.size.x];
        return tile;
    }

    public void SetMapTileColor(int x, int y)
    {
        Vector3Int test = new Vector3Int(7,4,0);
        
        Debug.Log(" tile:" + tileMap.GetColor(test));

        tileMap.SetColor(test, Color.red);
        
        Debug.Log(" tile:" + tileMap.GetColor(test));
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void HighLightGrids()
    {
        TileBase tile = GetMapTile(7, 4);
        
        Debug.Log(" tile:" + tile.name);

        SetMapTileColor(1, 1);
    }
}
