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
                print(BelongsTo.name + " was hit by hand by " + hand.BelongsTo.name);

            }
        }
        else if (other.gameObject.GetComponent<Foot>() != null)
        {
            Foot foot = other.gameObject.GetComponent<Foot>();
            if (foot.BelongsTo != BelongsTo)
            {
                print(BelongsTo.name + " was hit by foot by " + foot.BelongsTo.name);
            }
        }
        else if (other.gameObject.GetComponent<Body>() != null)
        {
            Body body = other.gameObject.GetComponent<Body>();
            if (body.BelongsTo != BelongsTo)
            {
                print(BelongsTo.name + " was hit by something " + body.BelongsTo.name);
            }
        }
    }
}
