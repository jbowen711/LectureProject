using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Billion : MonoBehaviour

{

    [SerializeField] GameObject flag;
    [SerializeField] GameObject HealthCircle;
    [SerializeField] int health = 3;
    public float billionSpeed = 3.0f;

    public GameObject Billion1Spawner;
    public float healthCirclesize = 1.0f;


    /*public List<GameObject> fl1 = new List<GameObject>();
    public List<GameObject> fl2 = new List<GameObject>();
    public List<GameObject> fl3 = new List<GameObject>();
    public List<GameObject> fl4 = new List<GameObject>();
    public bool flagExists = false;*/

    public GameObject[] billionsArray;
    // Start is called before the first frame update
    void Start()
    {
        


    }
    // Update is called once per frame
    void Update()
    {



        /*fl1.Add(GameObject.FindGameObjectWithTag("Flag1"));
        GameObject.FindGameObjectsWithTag("Flag2");
        GameObject.FindGameObjectsWithTag("Flag3");
        GameObject.FindGameObjectsWithTag("Flag3");
        GameObject.FindGameObjectsWithTag("Flag4");
        //Vector3 fl1Positon = fl1[0].transform.position;
        */

        
        
        //transform.position = Vector2.MoveTowards(transform.position, flag.transform.position, billionSpeed * Time.deltaTime);
        
        Vector3 mousePosition = Input.mousePosition;
        if (health < 1)
        {
            Die();
        }

        if (Input.GetMouseButtonDown(0) && Vector2.Distance(this.transform.position, Camera.main.ScreenToWorldPoint(mousePosition)) < .6f) {
            
            TakeDamage();
        }

        /*if (fl1 != null)
        {
            MoveBillions();
        }

        /*if (Input.GetMouseButtonDown(0))
        {
           target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           target.z = transform.position.z;
           MoveBillions(target);
        }
        */

        /*if (reference other billions arrays is within certain distance)
         * {
            transform.LookAt(reference other billion, Vector3.left)
        
           }
        */
    }


    /*void MoveBillions()
    {
        Debug.Log("Move Billions Called");
        foreach (GameObject billionObject in billionsArray)
        {
            // Find the closest flag in fl1
            GameObject closestFlag = FindClosestFlag(billionObject.transform.position, fl1);

            // Move the billion object towards the closest flag in fl1
            if (closestFlag != null)
            {
                Vector3 targetPosition = closestFlag.transform.position;
                billionObject.transform.position = Vector3.MoveTowards(billionObject.transform.position, targetPosition, billionSpeed * Time.deltaTime);
            }
        }
    }*/

    GameObject FindClosestFlag(Vector3 position, List<GameObject> flags)
    {
        GameObject closestFlag = null;
        float closestDistance = Mathf.Infinity;

        foreach (GameObject flag in flags)
        {
            if (flag != null)
            {
                float distanceToFlag = Vector3.Distance(position, flag.transform.position);
                if (distanceToFlag < closestDistance)
                {
                    closestFlag = flag;
                    closestDistance = distanceToFlag;
                }
            }
        }

        return closestFlag;
    }


    private void TakeDamage()
    {

        healthCirclesize = healthCirclesize - 0.2f;
        HealthCircle.gameObject.transform.localScale = new Vector3(healthCirclesize, healthCirclesize, 0f);
        Debug.Log(healthCirclesize);
   

        health -= 1;
        Debug.Log("DamageTaken");
        
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
