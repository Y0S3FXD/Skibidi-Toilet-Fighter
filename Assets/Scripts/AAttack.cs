using System.Security.AccessControl;
using UnityEngine;
using System;
using System.Collections;

public abstract class AAttack : MonoBehaviour
{
    public Toilet BelongsTo;
    public ParticleSystem PissParticle;
    public bool isEnemy;

    private float StaminaCost = 10f;
    private bool canShoot = true; // Renamed for clarity

    void Start()
    {
        collisionEvents = new List<ParticleCollisionEvent>();
        PissParticle = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        // Handling enemy attacks
        if (isEnemy && Input.GetButtonDown("Fire1") && canShoot && BelongsTo.CurrentStamina > StaminaCost)
        {
            Debug.Log($"Current Stamina: {BelongsTo.CurrentStamina}, Stamina Cost: {StaminaCost}, Can Shoot: {canShoot}");

            PerformAttack();
        }
        // Handling player attacks
        else if (!isEnemy && Input.GetKeyDown(KeyCode.Space) && canShoot && BelongsTo.CurrentStamina > StaminaCost)
        {
            Debug.Log($"Current Stamina: {BelongsTo.CurrentStamina}, Stamina Cost: {StaminaCost}, Can Shoot: {canShoot}");

            PerformAttack();
        }

        // Stopping the particle system when the button is released
        if ((isEnemy && Input.GetButtonUp("Fire1")) || (!isEnemy && Input.GetKeyUp(KeyCode.Space)))
        {
            PissParticle.Stop();
        }
    }

    private void PerformAttack()
    {
        PissParticle.Play();
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
