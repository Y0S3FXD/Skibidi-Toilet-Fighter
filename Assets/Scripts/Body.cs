using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : BodyPart
{
    public Toilet BelongsTo;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<BodyPart>() != null)
        {
            Body body = other.gameObject.GetComponent<Body>();
            if (body.BelongsTo != BelongsTo)
            {
                print(BelongsTo.name + " was hit by something " + body.BelongsTo.name);
            }
        }
    }
}
