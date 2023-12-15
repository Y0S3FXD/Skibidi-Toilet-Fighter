using System.Security.AccessControl;
using UnityEngine;
using System;

public class Attacks : MonoBehaviour
{
    public Toilet BelongsTo;
    public float criticalDamage;

    public void TakeDamage(float randomDamage)
    {
        
        BelongsTo.CurrentHealth -= randomDamage;
        BelongsTo.healthBar.SetHealth(BelongsTo.CurrentHealth);

    }
}
