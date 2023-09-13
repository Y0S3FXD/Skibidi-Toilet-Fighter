using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skibidi : MonoBehaviour
{
    string Name;

    void Start()
    {
        Name = "Skibidi_" + Random.Range(0, 1000);
    }
}