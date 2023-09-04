using System.Security.AccessControl;
using UnityEngine;
using System;

public class Attack : MonoBehaviour
{
    public float criticalDamage;

    public void DamageDealt(Toilet opponent)
    {
        float randomDamage = UnityEngine.Random.Range(criticalDamage * 0.66f, criticalDamage);
        opponent.Health -= randomDamage;
    }
}
