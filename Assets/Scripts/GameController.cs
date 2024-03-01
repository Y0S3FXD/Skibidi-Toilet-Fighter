using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject arenaPrefab; // Arena prefab
    public GameObject playerOnePrefab; // Player one prefab
    public GameObject playerTwoPrefab; // Player two prefab

    private Arena arenaInstance; // Instantiated arena

    void Start()
    {
        // Instantiate the arena
        GameObject arenaGO = Instantiate(arenaPrefab, Vector3.zero, Quaternion.identity);
        arenaInstance = arenaGO.GetComponent<Arena>();
        arenaInstance.CreateFloor(Vector3.zero);
        arenaInstance.CreateLight(new Vector3(0f, 10f, 0f));

        // Instantiate players
        Instantiate(playerOnePrefab, new Vector3(-2, 0, 0), Quaternion.identity); // Position for player one
        Instantiate(playerTwoPrefab, new Vector3(2, 0, 0), Quaternion.identity); // Position for player two
    }

    // Other GameController methods...
}


