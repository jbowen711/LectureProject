using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> fl1;
    private float speed = 3;
    void Start()
    {
        fl1 = new List<GameObject>(GameObject.FindGameObjectsWithTag("Flag1"));
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject closestFlag = FindClosestFlag(fl1);
        MoveTowards(closestFlag);

    }

    void MoveTowards(GameObject closestFlag)
    {
        Debug.Log("move towards called");
        if (closestFlag == null) return;
        transform.position = Vector2.MoveTowards(transform.position, closestFlag.transform.position, speed * Time.deltaTime);
        
    }

    public GameObject FindClosestFlag(List<GameObject> fl1)
    {
        //set float and flag to values that wont exceed in loop
        GameObject closestFlag = null;
        float closestDist = Mathf.Infinity;
        Vector2 currentFlagPos = transform.position;
        foreach (GameObject f in fl1)
        {
            float distance = Vector2.Distance(currentFlagPos, f.transform.position);

            if (distance < closestDist)
            {
                closestFlag = f;
                closestDist = distance;
            }




        }

        return closestFlag;
    }
}


