using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject playerOnePrefab; // Player one prefab
    public GameObject playerTwoPrefab; // Player two 
    public List<GameObject> Maps = new List<GameObject>(); 
    void Start()
    {
        // Instantiate the arena
        GameObject arenaGO = Instantiate(Maps[Random.Range(0,Maps.Count)], Vector3.zero, Quaternion.identity);
        // Instantiate players
        Instantiate(playerOnePrefab, new Vector3(-2, 0, 0), Quaternion.identity); // Position for player one
        Instantiate(playerTwoPrefab, new Vector3(2, 0, 0), Quaternion.identity); // Position for player two
    }

    // Other GameController methods...
}


