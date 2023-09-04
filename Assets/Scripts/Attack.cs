using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Attack : MonoBehaviour
{
    public float criticalDamage;
    public void voiddamageDealt(Toilet opponent)
    {
        Toilet.Health -= rnd.Next((criticalDamage * 0.66), criticalDamage);
    }
}