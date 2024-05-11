using System.Security.AccessControl;
using UnityEngine;
using System;
using System.Threading;

using System.Threading.Tasks;

public abstract class AAttack : MonoBehaviour, IAttack
{
    public Toilet BelongsTo;
    public float StaminaUsage;
    public float DamageAmount;

    public ParticleSystem AttackParticle;

    public void TakeStamina(Toilet BelongsTo, float Amount)
    {
        BelongsTo.UseStamina(Amount);
    }

    public void TakeDamage(Toilet Opponent, float Amount)
    {
        Opponent.TakeDamage(Amount);
    }

    void Start()
    {
        AttackParticle = GetComponent<ParticleSystem>();
    }

    public async void Attack()
    {
        BelongsTo.UseStamina(StaminaUsage);
        AttackParticle.Play();
        await Task.Delay(1000);
        AttackParticle.Stop();
    }

    void OnParticleCollision(GameObject collision)
    {
        GameObject collidedObject = collision.gameObject;
        if (collidedObject.CompareTag("Toilet"))
        {
            Toilet Toilet = collidedObject.GetComponent<Toilet>();
            if (Toilet != null && Toilet != BelongsTo)
            {
                TakeDamage(Toilet, DamageAmount);
            }
        }
    }
}
