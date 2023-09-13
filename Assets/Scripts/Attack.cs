using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Attack : IAttack
{
    /*To be able to implement a KO in a later sprint, damage is dealt as a procentage of health, 
   until the health is below a certain threshold where it deals absolute damage. If a KO i needed later the code for
   absoloute damage can be deleted and a KO added. Thereby a KO will not be called if the gameobject is dead(deleted)
   and there will always be a KO*/
    public float damageToDeal = 0.01f;

    public virtual void DealDamage(Toilet other)
    {
        other.Health = other.Health * (1 - damageToDeal);
    }
}