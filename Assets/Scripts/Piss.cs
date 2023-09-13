using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Piss : Attack
{

    public void Awake()
    {
        damageToDeal = Random.Range(0, 15);
    }

    public void usePiss(Toilet otherToilet)
    {
        if (otherToilet.Health < 10)
        {
            damageToDeal = 100;
        }
        DealDamage(otherToilet);
        Awake();
    }
}
