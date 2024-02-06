using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet : GameController
{
    public float Health = 100f;
    public bool IsPlayerOne = false;
    public Animator Anim;
    public Toilet Opponent;
    public Toilet MainBody;
    public Head MainHead;
    public float movespeed = 0.25f;
    public HealthBar healthbar;
    public float CurrentHealth;
    public float MaxHealth = 100f;
    private Rigidbody rb;
    private Vector3 arenaBounds = new Vector3(5f, 0f, 5f); // Bounds of the arena

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
        healthbar.SetMaxHealth(MaxHealth);
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
            StartButton.EndGame();
        }

        if (IsPlayerOne)
        {
            if (Opponent != null && MainBody != null)
            {
                MainBody.transform.LookAt(Opponent.MainBody.transform);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                PunchAnimation();
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                KickAnimation();
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                KissAnimation();
            }
            if (Input.GetKey(KeyCode.W))
            {
                MoveTowards();
            }
            if (Input.GetKey(KeyCode.S))
            {
                MoveAwayFrom();
            }
            if (Input.GetKey(KeyCode.T))
            {
                HeadButtAnimation();
            }
            if (Input.GetKey(KeyCode.A))
            {
                MoveToLeft();
            }
            if (Input.GetKey(KeyCode.D))
            {
                MoveToRight();
            }
        }
        else if (IsPlayerOne == false)
        {
            if (Opponent != null && MainBody != null)
            {
                MainBody.transform.LookAt(Opponent.MainBody.transform);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                PunchAnimation();
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                KickAnimation();
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                KissAnimation();
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                MoveTowards();
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                MoveAwayFrom();
            }
            if (Input.GetKey(KeyCode.V))
            {
                HeadButtAnimation();
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                MoveToLeft();
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                MoveToRight();
            }
        }

    }

    private void MoveTowards()
    {
        Vector3 newPosition = transform.position + Vector3.forward * movespeed;
        // Clamp the new position to the arena bounds
        newPosition.z = Mathf.Clamp(newPosition.z, -arenaBounds.z, arenaBounds.z);
        transform.position = newPosition;
    }

    private void MoveAwayFrom()
    {
        Vector3 newPosition = transform.position - Vector3.forward * movespeed;
        newPosition.z = Mathf.Clamp(newPosition.z, -arenaBounds.z, arenaBounds.z);
        transform.position = newPosition;
    }

    private void MoveToLeft()
    {
        Vector3 newPosition = transform.position - Vector3.right * movespeed;
        newPosition.x = Mathf.Clamp(newPosition.x, -arenaBounds.x, arenaBounds.x);
        transform.position = newPosition;
    }

    private void MoveToRight()
    {
        Vector3 newPosition = transform.position + Vector3.right * movespeed;
        newPosition.x = Mathf.Clamp(newPosition.x, -arenaBounds.x, arenaBounds.x);
        transform.position = newPosition;
    }
    private void PunchAnimation()
    {
        Anim.SetTrigger("Punch");

    }
    private void HeadButtAnimation()
    {
        Anim.SetTrigger("Headbutt");
    }
    private void KickAnimation()
    {
        Anim.SetTrigger("Kick");
    }
    private void KissAnimation()
    {
        Anim.SetTrigger("Kiss");
    }
    public void TakeDamage(float damage)
    {
        CurrentHealth -= damage;
        healthbar.SetHealth(CurrentHealth);
    }

}