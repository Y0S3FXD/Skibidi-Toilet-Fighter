using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HeadButt : Attack
{
    public void Awake()
    {
        damageToDeal = Random.Range(0, 15);
    }
    public void UseHeadButt(Toilet otherToilet)
    {
        if (otherToilet.IsCollidingWithPlayer == true)
        {
            if (otherToilet.Health < 10)
            {
                float damageToDeal = 100f;
            }
            else
            {
                float damageToDeal = 10f;
            }
        }
        else
        {
            if (otherToilet.IsPlayerOne == false)
            {
                Debug.Log("player one tried to headbutt player two, but wasnt colliding");
            }
            else
            {
                Debug.Log("player two tried to headbutt player one, but wasnt colliding");
            }
            DealDamage(otherToilet);
            Awake();
        }
    }
}