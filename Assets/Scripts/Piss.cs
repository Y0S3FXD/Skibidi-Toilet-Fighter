using UnityEngine;
using System.Threading.Tasks;
using System;

public class Piss : Attacks
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
