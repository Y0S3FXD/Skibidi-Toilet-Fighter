using UnityEngine;
//originally this code used both Start() and Update() however that was causing issues
public class Item : MonoBehaviour
{
    public GameObject bottlePrefab;
    public Toilet BelongsTo;
    //Takes in toilet and call it functiuon for health
    public async void GiveHealth(Toilet ToiletToHeal)
    {
        ToiletToHeal.TakeHealth(10.0f);
        Debug.Log("Health given");
    }
    //New bottle is created
    async void CreateItem(Vector3 position)
    {
        GameObject bottle = Instantiate(bottlePrefab, position, Quaternion.identity);
        bottle.transform.localScale = new Vector3(1f, 1f, 1f);
        Debug.Log("New item created");
    }
    //generate random vetor with a range for x and z, as it need to be
    Vector3 GenerateRandomVector()
    {
        float minX = -8;
        float maxX = 1;
        float minZ = -8f;
        float maxZ = 8;

        float randomX = Random.Range(minX, maxX);
        float randomZ = Random.Range(minZ, maxZ);

        return new Vector3(randomX, 2f, randomZ);
        Debug.Log("New position created");
    }
    void OnCollisionEnter(Collision collision)
    {
        //when something collides with the boittle it suicides and creates a new one
        Destroy(gameObject);
        CreateItem(GenerateRandomVector());
        Debug.Log("Item destroyed");
        GiveHealth(BelongsTo);
    }
}
