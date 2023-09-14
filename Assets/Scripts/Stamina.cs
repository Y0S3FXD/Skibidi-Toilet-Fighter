using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stamina : Piss
{
    // The time it takes for the object to disappear.
    private float LifeTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Handle collisions with other objects.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy1"))
        {
            Debug.Log("saloka hit an enemy: " + collision.gameObject.name);
            // Add your code to handle the collision with an enemy here.
            Destroy(gameObject); // Destroy the GameObject upon collision with any object.

        }
        else
        {
            Debug.Log("Stamina hit something else: " + collision.gameObject.name);
        }

    }
}
