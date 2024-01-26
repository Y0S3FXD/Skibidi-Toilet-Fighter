using System.Security.AccessControl;
using UnityEngine;
using System;

public class Attacks : MonoBehaviour
{
    public Toilet BelongsTo;
    public float criticalDamage;

    public void GiveDamage(Toilet opponent)
    {
        if (opponent.gameObject.CompareTag("Enemy1"))
        {
            Debug.Log("Stamina hit an enemy: " + BelongsTo.gameObject.name);
            // Add your code to handle the collision with an enemy here.
            BelongsTo.TakeDamage(1f); // Apply 10 damage to the character
        }
        else
        {
            Debug.Log("Stamina hit something else: ");
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy1"))
        {
            Debug.Log("1Stamina hit an enemy: " + collision.gameObject.name);
            // Add your code to handle the collision with an enemy here.
        }
        else
        {
            Debug.Log("1Stamina hit something else: ");
        }
    }
    
    }
