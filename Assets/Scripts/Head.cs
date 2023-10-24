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

        if (head != null && head.BelongsTo != null && BelongsTo != null)
        {
            print(BelongsTo.name + " was hit by head  from " + head.BelongsTo.name);
            // Handle collision with Head component
        }
        else if (body != null)
        {
            // Handle collision with Body component
        }
        else
        {
            // Handle collision with other colliders
        }
    }
}


}
