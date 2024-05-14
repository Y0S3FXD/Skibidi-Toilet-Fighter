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
    public float StaminaCost = 10.0f;
    public float AttackDamage = 10.0f;
    public bool canShoot = true;

    void Start()
    {
        collisionEvents = new List<ParticleCollisionEvent>();
        AttackParticle = GetComponent<ParticleSystem>();
    }

    public void PerformAttack()
    {
        BelongsTo.UseStamina(StaminaCost);
        AttackParticle.Play();
        StartCoroutine(AttackCooldown());
    }

    IEnumerator AttackCooldown()
    {
        canShoot = false;
        yield return new WaitForSeconds(3f);
        canShoot = true;
    }

    private List<ParticleCollisionEvent> collisionEvents;

    void OnParticleCollision(GameObject other)
    {
        Debug.Log("Particle hit something");
        ParticleSystem particleSystem = other.GetComponent<ParticleSystem>();
        if (particleSystem)
        {
            int numCollisionEvents = particleSystem.GetCollisionEvents(gameObject, collisionEvents);
            int i = 0;

            while (i < numCollisionEvents)
            {
                Debug.Log("Stamina hit an : " + BelongsTo.gameObject.name);
                BelongsTo.TakeDamage(AttackDamage);
                i++;
            }
        }
    }
}
