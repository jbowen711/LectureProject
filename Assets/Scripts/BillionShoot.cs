using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillionShoot : MonoBehaviour
{
    public GameObject shooter; 
    public GameObject orangeBase;
    public GameObject projectilePrefab;
    public GameObject target;
    public float shootInterval = 5f;
    public float shootingDistance = 100f;
    [SerializeField] float shootSpeed = 5f;
    private float timeSinceLastShoot;


    // Start is called before the first frame update
    void Start()
    {
        orangeBase = GameObject.FindGameObjectWithTag("OrangeBase");
        timeSinceLastShoot = shootInterval;
    }

    // Update is called once per frame
    void Update()
    {


        //TODO! Alogrithm to Determine Closest Base 
        target = orangeBase;
   
        if (TargetInRange())
        {
            timeSinceLastShoot += Time.deltaTime;

            if (timeSinceLastShoot >= shootInterval)
            {
                Shoot();
                timeSinceLastShoot = 0f;
            }
        }


    }

    bool TargetInRange()
    {
        float distance = Vector3.Distance(shooter.transform.position, target.transform.position);
        return distance <= shootingDistance;
    }
    void Shoot()
    {
        Debug.Log("Shot Called");
        Vector3 direction = (target.transform.position - shooter.transform.position).normalized;
        GameObject projectile = Instantiate(projectilePrefab, shooter.transform.position, Quaternion.identity);
        Rigidbody2D projectileRigidbody = projectile.GetComponent<Rigidbody2D>();
        if (projectileRigidbody != null)
        {
            projectileRigidbody.velocity = direction * shootSpeed;
        }
    }

}
