using System.Security.AccessControl;
using UnityEngine;
using System;

public class Attacks : MonoBehaviour
{
    public Toilet BelongsTo;
    public float criticalDamage;

    public void TakeDamage(float randomDamage)
    {
        
        BelongsTo.healthBar.SetHealth(randomDamage)
    }
}
