using UnityEngine;

public class Piss : Stamina
{
    public ParticleSystem PissParticle;
    public bool isEnemy; // Add a flag to distinguish between ally and enemy

    void Start()
    {
        PissParticle = GetComponent<ParticleSystem>();
    }

    void Update()
    {
    

        // Determine the correct input based on whether this is the enemy or ally
        if (isEnemy && Input.GetButtonDown("Fire1")) // Enemy fires with left mouse click
        {
            PissParticle.Play();
        }
        else if (!isEnemy && Input.GetKeyDown(KeyCode.Space)) // Ally fires with space bar
        {
            PissParticle.Play();
        }

        // Stop emitting if the input is released; this could also be separated for enemy and ally
        if ((isEnemy && Input.GetButtonUp("Fire1")) || (!isEnemy && Input.GetKeyUp(KeyCode.Space)))
        {
            PissParticle.Stop();
        }
    }
}
