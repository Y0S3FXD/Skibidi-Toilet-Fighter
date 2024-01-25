using UnityEngine;

public class Piss : Stamina
{
    public ParticleSystem waterStream;
    public Transform target; // Assign this in the Inspector

    void Start()
    {
        waterStream = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (target != null)
        {
            // Rotate the Particle System to face the target
            Vector3 directionToTarget = target.position - transform.position;
            Quaternion rotationToTarget = Quaternion.LookRotation(directionToTarget);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotationToTarget, Time.deltaTime * 10f); // Adjust the rotation speed as needed
        }

        if (Input.GetButtonDown("Fire1")) // Start emitting when the fire button is pressed
        {
            waterStream.Play();
        }

        if (Input.GetButtonUp("Fire1")) // Stop emitting when the fire button is released
        {
            waterStream.Stop();
        }
    }
}
