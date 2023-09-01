using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    public Mutant BelongsTo;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Hand>() != null)
        {
            Hand hand = other.gameObject.GetComponent<Hand>();
            if (hand.BelongsTo != BelongsTo)
            {
                print(BelongsTo.name + "was hit by" + hand.BelongsTo.name);
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mainbody")
        {
            Debug.Log("The player has collided!");
        }
    }
}
