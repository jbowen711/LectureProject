using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float spawnRate = .5f;
    [SerializeField] GameObject playerspawnpoint;
    public GameObject player;
    public GameObject[] billionsArray;
    public int billionsAmount;
    
    


    void Start()
    {

        billionsArray = new GameObject[100];
        InvokeRepeating("SpawnPlayer", .2f, spawnRate);
        
        

    }
    private void Update()
    {

        
    }

    // Update is called once per frame

    public void SpawnPlayer()
    {

        if (billionsAmount < billionsArray.Length)
        {
            //Instantiating Object
            GameObject tempObj = Instantiate(player, playerspawnpoint.transform.position, Quaternion.identity);
            //Adding to Array
            billionsArray[billionsAmount] = tempObj;
            Debug.Log(billionsAmount);
            billionsAmount++;
        }
        

        
        
    }

    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "PlayerSpawn")
        {
            gameObject.transform.position = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
            Debug.Log("Collison Detected");
        }
        
    }



}
