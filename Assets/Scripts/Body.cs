using UnityEngine;
using System.Collections.Generic;

public class Body : MonoBehaviour
{
    public Toilet BelongsTo;
    private List<ParticleCollisionEvent> collisionEvents;

    void Start()
    {
        collisionEvents = new List<ParticleCollisionEvent>();
    }

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
