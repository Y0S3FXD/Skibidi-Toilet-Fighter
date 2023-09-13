using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piss : MonoBehaviour
{
    public Transform PissSpawnPoint;
    public GameObject PissPreFap;
    public float PissSpeed = 1.0f;
    public float SpawnRate = 0.1f; // Adjust this to control the rate of spawning.

    private float timeSinceLastSpawn = 0f;

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        // Check if it's time to spawn a new "piss" object.
        if (timeSinceLastSpawn >= SpawnRate)
        {
            SpawnPiss();
            timeSinceLastSpawn = 0f; // Reset the timer.
        }
    }

    private void SpawnPiss()
    {
        var pisso = Instantiate(PissPreFap, PissSpawnPoint.position, PissSpawnPoint.rotation);
        pisso.GetComponent<Rigidbody>().velocity = PissSpawnPoint.forward * PissSpeed;
    }
}
