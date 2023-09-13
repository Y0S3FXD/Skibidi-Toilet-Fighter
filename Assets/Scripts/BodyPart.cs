
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BodyPart : MonoBehaviour
{
    public int age;
    public Toilet BelongsTo;

    void OnCollisionEnter(Collision collision)
    {
        print("collision detected");
    }

    void OnTriggerEnter(Collider other)
    {
        print("trigger detected");
    }

}