using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arena : MonoBehaviour
{




private void SpawnHealthRegen(List<GameObject> HealthRegen)
    {
        if (HealthRegen.Count > 0)
        {
            GameObject healthRegen = HealthRegen[0];
            HealthRegen.RemoveAt(0);
            healthRegen.SetActive(true);
            healthRegen.transform.position = new Vector3(Random.Range(-5f, 5f), 0.5f, Random.Range(-5f, 5f));
        }
    }
}