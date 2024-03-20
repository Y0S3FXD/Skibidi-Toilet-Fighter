using UnityEngine;
//In a later rendition it might make sense to make the class arena intoa singletonm however as it stands it is not necessary
public class Arena : MonoBehaviour
{
    public GameObject floorPrefab;
    public GameObject wallPrefab;
    public Light arenaLight;

    public void CreateFloor(Vector3 position)
    {
        GameObject floor = Instantiate(floorPrefab, position, Quaternion.identity);
        floor.transform.localScale = new Vector3(20f, 0.1f, 20f); // Adjust the size as needed
    }
    public void CreateLight(Vector3 position)
    {
        Instantiate(arenaLight, position, Quaternion.Euler(45f, 45f, 0f));
    }
}
