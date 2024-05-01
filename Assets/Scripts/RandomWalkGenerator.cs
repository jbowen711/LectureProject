using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomWalkGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    protected Vector2Int startPos = Vector2Int.zero;

    [SerializeField]
    private int iterations = 10;

    [SerializeField]
    public int walkLength = 10;

    [SerializeField]
    public bool startRandomlyEachIteration = true;

    [SerializeField]
    private TileMapVisualizer tileMapVisualizer;


    private void Start()
    {
        RunProceduralGeneration();
    }
    public void RunProceduralGeneration()
    {
        HashSet<Vector2Int> floorPositions = RunRandomWalk();
        tileMapVisualizer.RemoveFloorTiles(floorPositions);
    }

    protected HashSet<Vector2Int> RunRandomWalk()
    {
        var currentPos = startPos;
        HashSet<Vector2Int> floorPositions = new HashSet<Vector2Int>();
        for (int i = 0; i < iterations; i++)
        {
            var path = ProceduralAlgorithm.SimpleRandomWalk(currentPos, walkLength);
            floorPositions.UnionWith(path);
            if (startRandomlyEachIteration)
            {
                currentPos = floorPositions.ElementAt(Random.Range(0, floorPositions.Count));

            }

            
        }
        return floorPositions;

    }
}
