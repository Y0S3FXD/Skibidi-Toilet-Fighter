using UnityEngine;

public class Arena : MonoBehaviour
{
    public GameObject floorPrefab;
    public GameObject wallPrefab;
    public Light arenaLight;

    public void CreateFloor(Vector3 position)
    {
        GameObject floor = Instantiate(floorPrefab, position, Quaternion.identity);
        floor.transform.localScale = new Vector3(10f, 0.1f, 10f); // Adjust the size as needed
    }

    public void CreateWall(Vector3 position, Quaternion rotation)
    {
        GameObject wall = Instantiate(wallPrefab, position, rotation);
        wall.transform.localScale = new Vector3(0.1f, 2f, 10f); // Adjust the size as needed
    }

    // Create walls with predefined positions and rotations
    public void CreateWalls()
    {
        CreateWall(new Vector3(5f, 2.5f, 0f), Quaternion.Euler(0f, 0f, 0f));
        CreateWall(new Vector3(-5f, 2.5f, 0f), Quaternion.Euler(0f, 0f, 0f));
        CreateWall(new Vector3(0f, 2.5f, -5f), Quaternion.Euler(0f, 90f, 0f));
        CreateWall(new Vector3(0f, 2.5f, 5f), Quaternion.Euler(0f, 90f, 0f));
    }

    public void CreateLight(Vector3 position)
    {
        Instantiate(arenaLight, position, Quaternion.Euler(45f, 45f, 0f));
    }
}
