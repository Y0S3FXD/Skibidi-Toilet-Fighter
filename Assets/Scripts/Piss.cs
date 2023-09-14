using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piss : Attacks
{
    public Transform PissSpawnPoint;
    public GameObject PissPreFap;
    public float PissSpeed = 23.5f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 10; i++)
            {
                var pisso = Instantiate(PissPreFap, PissSpawnPoint.position, PissSpawnPoint.rotation);
                Rigidbody pissRigidbody = pisso.GetComponent<Rigidbody>();
                pissRigidbody.velocity = PissSpawnPoint.forward * PissSpeed;
            }
        }
    }

    // Handle collisions with any object and destroy the "piss" object.
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject); // Destroy the "piss" object upon collision with any object.
    }
}
