using UnityEngine;
//originally this code used both Start() and Update() however that was causing issues
public class Item : MonoBehaviour
{
    public GameObject bottlePrefab;

    public void CreateItem(Vector3 position)
    {
        GameObject bottle = Instantiate(bottlePrefab, position, Quaternion.identity);
        bottle.transform.localScale = new Vector3(1f, 1f, 1f);
    }
    Vector3 GenerateSemiRandomVector()
    {
        float minX = -8;
        float maxX = 1;
        float minZ = -8f;
        float maxZ = 8;

        float randomX = Random.Range(minX, maxX);
        float randomZ = Random.Range(minZ, maxZ);

        return new Vector3(randomX, 2f, randomZ);
    }
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Vector3 newPosition = GeneratesemiRandomVector();
        CreateItem(newPosition);
    }
}
