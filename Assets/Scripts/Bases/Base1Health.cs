using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Base1Health : MonoBehaviour
{
    // Start is called before the first frame update

    
    public Image healthBar;

    [SerializeField] private Slider slider;
    [SerializeField] private float maxHealth = 100;
    [SerializeField] private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        
    }

    private void Update()
    {
        healthBar.fillAmount = currentHealth / maxHealth;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }
        
    }
    public void TakeDamage(int damage)
    {
        if ( currentHealth > 0)
        {
            currentHealth -= damage;

            

        }
        
    }






}
