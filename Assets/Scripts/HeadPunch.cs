using UnityEngine;

public class HeadPunch : Attacks
{
    // Adjust this value as needed for the damage of the HeadPunch attack
    public float damage = 20f;

    // Reference to the skibidi-toilet character
    public Toilet BelongsToCharacter;

    // OnTriggerEnter is called when a collision with a trigger collider occurs
    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has a "Body" or "Head" component
            Debug.Log("HeadPunch OnTriggerEnter called with: " + other.name);

        Body body = other.gameObject.GetComponent<Body>();
        Head head = other.gameObject.GetComponent<Head>();

        if (body != null || head != null)
        {
            // Check if the collided body or head belongs to the opponent
            Toilet opponent = body != null ? body.BelongsTo : head.BelongsTo;

            if (opponent != null && opponent != BelongsToCharacter)
            {
                // Apply damage to the opponent
                opponent.TakeDamage(damage);

                // Print a message to the console for testing
                Debug.Log(BelongsToCharacter.name + " punched " + opponent.name + " for " + damage + " damage");

                // You can also trigger attack-related animations or effects here
            }
        }
    }

    // Additional methods for handling the "HeadPunch" attack behavior
}
