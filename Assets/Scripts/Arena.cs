using UnityEngine;

public class Arena : MonoBehaviour
{
    public GameObject floorPrefab;
    public GameObject wallPrefab;
    public Light arenaLight;

    public void Start()
    {
        CreateArena();
    }

    public void CreateArena()
    {
        CreateFloor();
        CreateWalls();
        CreateLight();
    }

    public void CreateFloor()
    {
        GameObject floor = Instantiate(floorPrefab, Vector3.zero, Quaternion.identity);
        floor.transform.localScale = new Vector3(10f, 0.1f, 10f); // Adjust the size as needed
    }

    public void CreateWalls()
    {
        // Create walls (adjust size and position as needed)
        CreateWall(new Vector3(5f, 2.5f, 0f), Quaternion.Euler(0f, 0f, 0f));
        CreateWall(new Vector3(-5f, 2.5f, 0f), Quaternion.Euler(0f, 0f, 0f));
        CreateWall(new Vector3(0f, 2.5f, -5f),Quaternion.Euler(0f, 90f, 0f));
        CreateWall(new Vector3(0f, 2.5f, 5f),Quaternion.Euler(0f, 90f, 0f));
    }

public void CreateWall(Vector3 position, Quaternion rotation = default)
{
    GameObject wall = Instantiate(wallPrefab, position, rotation);
    wall.transform.localScale = new Vector3(0.1f, 2f, 10f); // Adjust the size as needed
}


    public void CreateLight()
    {
        Instantiate(arenaLight, new Vector3(0f, 10f, 0f), Quaternion.Euler(45f, 45f, 0f));
    }
}
