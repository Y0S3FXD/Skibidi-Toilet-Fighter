using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet : MonoBehaviour
{
    public float Health = 100f;
    public bool IsPlayerOne = false;
    public Toilet Opponent;
    public Toilet MainBody;
    public float movespeed = 5.25f;
    public HealthBar healthbar;
    public float CurrentHealth;
    public float MaxHealth = 100;
    private Rigidbody rb;
    private Vector3 arenaBounds = new Vector3(5f, 0f, 5f);

    public float rotationSpeed = 100.0f;
    private float rotation;

    void Start()
    {
        CurrentHealth = MaxHealth;
        healthbar.SetMaxHealth(MaxHealth);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        if (CurrentHealth <= 0)
        {
            //If health goes at or below zero the toilet dies and the games goes back to the start
            Destroy(gameObject);
            StartButton.EndGame();
        }
        if (CurrentHealth > MaxHealth)
        {
            //If health goes above MacHealth it will be set to MaxHealth, thus making sure that health can't go above 100
            CurrentHealth = MaxHealth;
            Debug.Log("Health reset to " + CurrentHealth);
        }
        else { }

        if (transform.position.y < -10f)
        {
            //If the y-poston of the toilet is under -10 the toilet dies as its health is reduced
            CurrentHealth = -100f;
            Debug.Log("Toilet died from falling");
        }

        if (IsPlayerOne)
        {

            if (Input.GetKey(KeyCode.W))
            {
                MoveTowards();
            }
            if (Input.GetKey(KeyCode.S))
            {
                MoveAwayFrom();
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


            if (Input.GetKey(KeyCode.UpArrow))
            {
                MoveTowards();
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                MoveAwayFrom();
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
        transform.Translate(0, 0, movespeed * Time.deltaTime);
    }

    private void MoveAwayFrom()
    {
        transform.Translate(0, 0, movespeed * -Time.deltaTime);

    }
    private void MoveToLeft()
    {
        transform.Rotate(0, 90 * -Time.deltaTime, 0); // Adjust the rotation speed as needed
    }

    private void MoveToRight()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0); // Adjust the rotation speed as needed

    }
    /*
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
    }*/
    public void TakeDamage(float damage)
    {
        CurrentHealth -= damage;
        healthbar.SetHealth(CurrentHealth);
    }
    public void TakeHealth(float regenAmount)
    {
        CurrentHealth += regenAmount;
        healthbar.SetHealth(CurrentHealth);
    }

}