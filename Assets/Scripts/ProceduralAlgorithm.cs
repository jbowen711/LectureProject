using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralAlgorithm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static HashSet<Vector2Int> SimpleRandomWalk(Vector2Int startPos, int walkLength)
    {
        HashSet<Vector2Int> path = new HashSet<Vector2Int>();
        path.Add(startPos);
        var previousPos = startPos;

        for (int i = 0; i < walkLength; i++)
        {
            var newPos = previousPos + Direction2D.GetRandomCardinalDirection();
            path.Add(newPos);
            previousPos = newPos;

        }
        return path;
    }

    

        

}

public static class Direction2D
{
    public static List<Vector2Int> cardinalDirectionsList = new List<Vector2Int>
    {
        new Vector2Int(0, 1),//UP
        new Vector2Int(-1, 0), //LEFT
        new Vector2Int(0, -1), //DOWN
        new Vector2Int(1, 0), // RIGHT
        
    };

    public static Vector2Int GetRandomCardinalDirection()
    {
        return cardinalDirectionsList[Random.Range(0, cardinalDirectionsList.Count)];
    }
}
