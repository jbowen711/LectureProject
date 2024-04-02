using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject purpleFlag;
    private float speed = 3;
    void Start()
    {
        purpleFlag = GameObject.FindGameObjectWithTag("Flag1");
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowards();
    }

    void MoveTowards()
    {
        transform.position = Vector3.MoveTowards(transform.position, purpleFlag.transform.position, speed * Time.deltaTime);
    }
}


