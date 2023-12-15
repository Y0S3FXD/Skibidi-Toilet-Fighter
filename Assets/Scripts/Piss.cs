using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piss : Stamina
{
    public Transform PissSpawnPoint;
    public GameObject PissPreFap;
    public float PissSpeed = 0.5f;

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
}
