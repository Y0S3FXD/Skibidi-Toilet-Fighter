using System.Security.AccessControl;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public abstract class AAttack : MonoBehaviour
{
    public Toilet BelongsTo;
    public ParticleSystem AttackParticle;
    public bool isEnemy;

    public float StaminaCost = 10f;
    public bool canShoot = true;

    void Start()
    {
        collisionEvents = new List<ParticleCollisionEvent>();
        AttackParticle = GetComponent<ParticleSystem>();
    }

    public void PerformAttack()
    {
        AttackParticle.Play();
        BelongsTo.UseStamina(StaminaCost);
        StartCoroutine(AttackCooldown());
    }

    IEnumerator AttackCooldown()
    {
        canShoot = false;
        yield return new WaitForSeconds(3f); // Wait for 3 seconds
        canShoot = true;
    }

    private List<ParticleCollisionEvent> collisionEvents;

    void OnParticleCollision(GameObject other)
    {
        ParticleSystem particleSystem = other.GetComponent<ParticleSystem>();
        if (particleSystem)
        {
            int numCollisionEvents = particleSystem.GetCollisionEvents(gameObject, collisionEvents);
            int i = 0;

            while (i < numCollisionEvents)
            {
                Debug.Log("Stamina hit an : " + BelongsTo.gameObject.name);
                // Here you can handle the collision event, e.g., apply damage
                BelongsTo.TakeDamage(1f); // Apply 10 damage to the character
                i++;
            }
        }
    }
}
