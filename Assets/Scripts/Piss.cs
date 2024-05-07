using UnityEngine;
using System.Threading.Tasks;
using System;
using Unity.VisualScripting;

public class Piss : AAttack
{
    void Start()
    {
        StaminaUsage = 5f;
        DamageAmount = 5f;
    }

    void Update()
    {
        if (BelongsTo.IsPlayerOne && Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
        else if (!BelongsTo.IsPlayerOne && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
    }
}

/*d
{
    public ParticleSystem PissParticle;
    public bool isEnemy;

    void Start()
    {
        PissParticle = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (isEnemy && Input.GetButtonDown("Fire1")) // Fire1 er inbygget funktion i Unity, som er knyttet til venstre museklik
        {
            PissParticle.Play();
        }
        else if (!isEnemy && Input.GetKeyDown(KeyCode.Space)) // Anden spiller bruger space
        {
            PissParticle.Play();
        }

        if ((isEnemy && Input.GetButtonUp("Fire1")) || (!isEnemy && Input.GetKeyUp(KeyCode.Space)))
        {
            PissParticle.Stop();

        }
    }
}
*/
