using System.Security.AccessControl;
using UnityEngine;
using System;

public class Attacks : MonoBehaviour
{
    public Toilet BelongsTo;
    public float criticalDamage;

    public void GiveDamage(Toilet opponent)
    {
        float randomDamage = UnityEngine.Random.Range(criticalDamage * 0.66f, criticalDamage);
        opponent.Health -= randomDamage;
    }
}
