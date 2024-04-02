using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject flag1;
    [SerializeField] GameObject flag2;
    [SerializeField] GameObject flag3;
    [SerializeField] GameObject flag4;

    Vector3 flagSpawn;

    public List<GameObject> fl1 = new List<GameObject>();
    public List<GameObject> fl2 = new List<GameObject>();
    public List<GameObject> fl3 = new List<GameObject>();
    public List<GameObject> fl4 = new List<GameObject>();


    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        flagSpawn = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        flagSpawn.z = -.5f;
        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Spawned Flag");
            GameObject flag = Instantiate(flag1, flagSpawn, Quaternion.identity);
            fl1.Add(flag);
            
        }
        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.W))
        {
            Debug.Log("Spawned Flag2");
            GameObject flag = Instantiate(flag2, flagSpawn, Quaternion.identity);
            fl2.Add(flag);

        }
        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.E))
        {
            Debug.Log("Spawned Flag3");
            GameObject flag = Instantiate(flag3, flagSpawn, Quaternion.identity);
            fl3.Add(flag);

        }
        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.R))
        {
            Debug.Log("Spawned Flag4");
            GameObject flag = Instantiate(flag4, flagSpawn, Quaternion.identity);
            fl4.Add(flag);

        }

    }
}
