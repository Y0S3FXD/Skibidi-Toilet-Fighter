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
        }

    }

    private void MoveTowards()
    {
        Vector3 direction = Opponent.MainBody.transform.position - MainBody.transform.position;
        Vector3 normalizedDirection = direction.normalized;
        Vector3 movement = normalizedDirection * 0.01f;
        transform.position += movement;
    }
    private void MoveAwayFrom()
    {
        Vector3 direction = Opponent.MainBody.transform.position - MainBody.transform.position;
        Vector3 normalizedDirection = direction.normalized;
        Vector3 movement = normalizedDirection * 0.01f;
        transform.position -= movement;
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