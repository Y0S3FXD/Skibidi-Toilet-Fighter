using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
 public Toilet BelongsTo;
    // write a collider that write you got hit

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Body got hit by " + collision.gameObject.name);
    }



}

