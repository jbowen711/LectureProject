using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapVisualizer : MonoBehaviour
{
    [SerializeField]
    private Tilemap floorMap;


    [SerializeField]
    private TileBase floorBase;

    public void RemoveFloorTiles(IEnumerable<Vector2Int> floorPositions)
    {
        RemoveTiles(floorPositions, floorMap, floorBase);
    }

    private void RemoveTiles(IEnumerable<Vector2Int> positions, Tilemap tileMap, TileBase tile)
    {
        foreach(var position in positions)
        {
            RemoveSingleTile(tileMap, tile, position);

            
        }
    }

    private void RemoveSingleTile(Tilemap tileMap, TileBase tile, Vector2Int position)
    {
        var tilePosition = tileMap.WorldToCell((Vector3Int)position);
        tileMap.SetTile(tilePosition, null);
    }
}
