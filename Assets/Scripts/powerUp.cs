using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{

    public GameObject pUp;
    public Vector2 spawnArea;
    private float delay = 15;
    int countPower;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPowerUp());
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    IEnumerator SpawnPowerUp()

    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            Vector2 spawnPosition = GetRandomSpawnPosition();
            Debug.Log("Spawn Position: " + spawnPosition);
            Instantiate(pUp, spawnPosition, Quaternion.identity);
            countPower++;
            if (countPower > 15)
            {
                yield break;
            }
            
        }
        
    }

    Vector2 GetRandomSpawnPosition()
    {
        float randomX = Random.Range(transform.position.x - spawnArea.x, transform.position.x + spawnArea.x);
        float randomY = Random.Range(transform.position.y - spawnArea.y, transform.position.y + spawnArea.y);
        return new Vector2(randomX, randomY);
    }
}
