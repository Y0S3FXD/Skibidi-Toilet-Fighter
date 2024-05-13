using UnityEngine;
using System.Collections;
public class Shit : AAttack
{
    void Update()
    {
        // Handling enemy attacks
        if (
            isEnemy
            && Input.GetButtonDown("Fire2")
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
            && Input.GetKeyDown(KeyCode.C)
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
        if ((isEnemy && Input.GetButtonUp("Fire2")) || (!isEnemy && Input.GetKeyUp(KeyCode.C)))
        {
            AttackParticle.Stop();
        }
    }
}
