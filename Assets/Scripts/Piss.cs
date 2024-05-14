using UnityEngine;
using System.Collections;

public class Piss : AAttack
{
    void Awake()
    {
        StaminaCost = 10f;
        AttackDamage = 2f;
    }

    void Update()
    {
        // Handling enemy attacks
        if (
            isEnemy
            && Input.GetButtonDown("Fire1")
            && canShoot
            && BelongsTo.CurrentStamina > StaminaCost
        )
        {
            Debug.Log(
                $"Current Stamina: {BelongsTo.CurrentStamina}, Stamina Cost: {StaminaCost}, Can Shoot: {canShoot}"
            );

            PerformAttack();
        }
        // Handling player attacks
        else if (
            !isEnemy
            && Input.GetKeyDown(KeyCode.Space)
            && canShoot
            && BelongsTo.CurrentStamina > StaminaCost
        )
        {
            Debug.Log(
                $"Current Stamina: {BelongsTo.CurrentStamina}, Stamina Cost: {StaminaCost}, Can Shoot: {canShoot}"
            );

            PerformAttack();
        }

        // Stopping the particle system when the button is released
        if ((isEnemy && Input.GetButtonUp("Fire1")) || (!isEnemy && Input.GetKeyUp(KeyCode.Space)))
        {
            AttackParticle.Stop();
        }
    }
}
