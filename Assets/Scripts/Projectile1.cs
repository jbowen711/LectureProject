using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile1 : MonoBehaviour
{
    // Start is called before the first frame update
    private OrangeBaseHealth orangeBaseHealth;

    void Start()
    {
        GameObject orangeBase = GameObject.FindGameObjectWithTag("OrangeBase");
        if (orangeBase != null)
        {

            orangeBaseHealth = orangeBase.GetComponent<OrangeBaseHealth>();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("OrangeBase"))
        {
            orangeBaseHealth.TakeDamage(10f);
            Debug.Log("Collision Called");
            Destroy(gameObject);

        }
    }
}
