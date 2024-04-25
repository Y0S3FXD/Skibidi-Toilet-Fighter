using UnityEngine;
using System.Collections; // Import for coroutines

public class Piss : Attacks
{
    public ParticleSystem PissParticle;
    public bool isEnemy;

    private float StaminaCost = 10f;
    private bool canShoot = true; // Renamed for clarity

    void Start()
    {
        PissParticle = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        // Handling enemy attacks
        if (isEnemy && Input.GetButtonDown("Fire1") && canShoot && BelongsTo.Stamina > StaminaCost)
        {
            Debug.Log($"Current Stamina: {BelongsTo.CurrentStamina}, Stamina Cost: {StaminaCost}, Can Shoot: {canShoot}");

            PerformAttack();
        }   
        // Handling player attacks
        else if (!isEnemy && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"Current Stamina: {BelongsTo.CurrentStamina}, Stamina Cost: {StaminaCost}, Can Shoot: {canShoot}");

            PissParticle.Play();
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
}
