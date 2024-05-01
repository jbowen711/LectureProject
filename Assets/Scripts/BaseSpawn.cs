using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BaseSpawner : MonoBehaviour
{

    [SerializeField] Tilemap tilemap;
    public GameObject[] billionBase;
    public Vector2 spawnRange = new Vector2(10f, 10f);

    void Start()
    {
        //SpawnBases();
        
    }


    void SpawnBases()
    {
        for (int i = 1; i < 5; i++)
        {
            //Vector3 billionBasePos =
            //Instantiate(billionBase[i], billionBasePos, Quaternion.identity);
        }
    }

}


