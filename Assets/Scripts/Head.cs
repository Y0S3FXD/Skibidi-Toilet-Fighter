using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public Toilet BelongsTo;
    // write a collider that write you got hit by enemy body
    void OnTriggerEnter(Collider other)
{
    if (other != null)
    {
        Body body = other.gameObject.GetComponent<Body>();
        Head head = other.gameObject.GetComponent<Head>();

        if (body != null)
        {
                            print(BelongsTo.name + " was hit by something body  " + body.BelongsTo.name);

            // Handle collision with Body component
        }
        else if (head != null)
        {
                            print(BelongsTo.name + " was hit by something head  " + head.BelongsTo.name);

            // Handle collision with Head component
        }
        else{
            print("ignore " + other.name);
        }
    }
}

}

