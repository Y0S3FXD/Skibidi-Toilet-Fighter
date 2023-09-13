using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
 Head head;
 public Toilet BelongsTo;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Head>() != null)
        {
             Head head = other.gameObject.GetComponent<Head>();
            if (head.BelongsTo != BelongsTo)
            {
                print(BelongsTo.name + " was hit by something " + head.BelongsTo.name);
            }
        }
    }
}

