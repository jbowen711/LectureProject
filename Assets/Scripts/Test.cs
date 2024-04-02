using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToObject : MonoBehaviour
{
    public GameController gameController;
    public float movementSpeed = 5f;
    private GameObject targetFlag;

    void Start()
    {
        // Assuming you have a GameController script attached to the same GameObject
        gameController = GameObject.FindObjectOfType<GameController>();

        // Assuming you want the object to move towards the first flag in fl1 list
        if (gameController.fl1.Count > 0)
        {
            targetFlag = gameController.fl1[0];
        }
    }

    void Update()
    {
        if (targetFlag != null)
        {
            // Calculate direction to the target flag
            Vector3 direction = (targetFlag.transform.position - transform.position).normalized;

            // Move the object towards the target flag
            transform.Translate(direction * movementSpeed * Time.deltaTime);
        }
    }
}
