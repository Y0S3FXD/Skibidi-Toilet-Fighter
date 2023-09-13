using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject arenaPrefab; // Reference to the arena prefab
    
    private Arena arenaInstance; // Reference to the instantiated arena

    void Start()
    {
        // Spawn the arena
        GameObject arenaGO = Instantiate(arenaPrefab, Vector3.zero, Quaternion.identity);
        arenaInstance = arenaGO.GetComponent<Arena>();

        // Create the arena components
        arenaInstance.CreateFloor(Vector3.zero);
        arenaInstance.CreateWalls();
        arenaInstance.CreateLight(new Vector3(0f, 10f, 0f));

        // Other initialization code...
    }

    // Other GameController methods...
}


