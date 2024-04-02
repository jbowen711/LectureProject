using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float spawnRate = .5f;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject enemySpawn;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", .2f, spawnRate);

    }

    // Update is called once per frame

    public void SpawnEnemy()
    {

        Instantiate(enemy, enemySpawn.gameObject.transform.position, Quaternion.identity);
    }
}