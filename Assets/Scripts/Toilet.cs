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
    public  float movespeed  = 0.25f; 
    public HealthBar healthbar;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

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
        // Define a forward direction vector (in Unity, forward is usually Vector3.forward).
        Vector3 forwardDirection = Vector3.forward;

        // You can adjust the speed by changing the multiplier.
        float speed = movespeed;

        // Calculate the movement vector.
        Vector3 movement = forwardDirection * speed;

        // Update the position to move the object forward.
        transform.position += movement;
    }
    private void MoveAwayFrom()
    {
        // Define a backward direction vector (in Unity, backward is usually -Vector3.forward).
        Vector3 backwardDirection = -Vector3.forward;

        // You can adjust the speed by changing the multiplier.
        float speed = movespeed;

        // Calculate the movement vector.
        Vector3 movement = backwardDirection * speed;

        // Update the position to move the object backward.
        transform.position += movement;
    }
    private void MoveToLeft()
    {
        // Define a left direction vector (in Unity, left is usually -Vector3.right).
        Vector3 leftDirection = -Vector3.right;

        // You can adjust the speed by changing the multiplier.
        float speed = movespeed;

        // Calculate the movement vector.
        Vector3 movement = leftDirection * speed;

        // Update the position to move the object to the left.
        transform.position += movement;
    }
    private void MoveToRight()
    {
        // Define a right direction vector (in Unity, right is usually Vector3.right).
        Vector3 rightDirection = Vector3.right;

        // You can adjust the speed by changing the multiplier.
        float speed = movespeed;

        // Calculate the movement vector.
        Vector3 movement = rightDirection * speed;

        // Update the position to move the object to the right.
        transform.position += movement;
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
        Health -= damage;
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

}