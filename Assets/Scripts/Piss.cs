using System.Runtime.InteropServices;
using System.ComponentModel;
using UnityEngine.Events;
using UnityEngine;

public class Piss : Stamina
{
    public float PissCooldown;
    private float CurrentCooldown;
    public bool automatic;
    public Transform PissSpawnPoint;
    public GameObject PissPreFap;
    public float PissSpeed = 0.5f;
    public UnityEvent onshoot;

    private void Start()
    {
        CurrentCooldown = PissCooldown;
    }
    private void Update()
    {
        if (automatic)
        {
            if (Input.GetMouseButton(0))
            {
                if (CurrentCooldown <= 0)
                {
                    CurrentCooldown = PissCooldown;
                    onshoot?.Invoke();
                }
                else
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        if (CurrentCooldown <= 0)
                        {
                            CurrentCooldown = PissCooldown;
                            onshoot?.Invoke();
                        }
                    }
                }
            }
            /*for (int i = 0; i < 10; i++)
            {
                var pisso = Instantiate(PissPreFap, PissSpawnPoint.position, PissSpawnPoint.rotation);
                Rigidbody pissRigidbody = pisso.GetComponent<Rigidbody>();
                pissRigidbody.velocity = PissSpawnPoint.forward * PissSpeed;
            }*/
            CurrentCooldown -= Time.deltaTime;
        }
    }
}
