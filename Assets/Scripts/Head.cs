using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public Toilet BelongsTo;
    // Vollider detects when bodies collide
    void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            Body body = other.gameObject.GetComponent<Body>();
            Head head = other.gameObject.GetComponent<Head>();

            if (head != null && head.BelongsTo != null && BelongsTo != null)
            {
                print(BelongsTo.name + " was hit by head  from " + head.BelongsTo.name);
                // Handle collision with Head component
                BelongsTo.TakeDamage(25f); // Apply 10 damage to the character
            }
            else if (body != null)
            {
                // Handle collision with Body component
            }
            else
            {
                // Handle collision with other colliders
            }
        }
    }


}

