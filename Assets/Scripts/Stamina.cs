using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina : Attacks
{
    // The time it takes for the object to disappear.
    private float LifeTime = 3.0f;

    void Start()
    {
    }

    // Handle collisions with other objects.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy1"))
        {
            Debug.Log("Stamina hit an enemy: " + collision.gameObject.name);
            // Add your code to handle the collision with an enemy here.
            Destroy(gameObject); // Destroy the "Stamina" object that collided with an enemy.
        }
        else
        {
            Debug.Log("Stamina hit something else: ");
        }
    }
}
