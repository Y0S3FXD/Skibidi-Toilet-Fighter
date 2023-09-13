using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
 public Toilet BelongsTo;
    // write a collider that write you got hit

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Attack"))
        {
            Attacks attack = other.gameObject.GetComponent<Attacks>();
            if (attack != null)
            {
                BelongsTo.Health -= attack.Damage;
            }
        }
    }

    
}

