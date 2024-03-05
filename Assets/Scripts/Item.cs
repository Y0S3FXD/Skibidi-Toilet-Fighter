using UnityEngine;
//originally this code used both Start() and Update() however that was causing issues
public class Item : MonoBehaviour
{
    public GameObject bottlePrefab;
    //Takes in toilet and call it functiuon for health
    public void GiveHealth(Toilet ToiletToHeal)
    {
        ToiletToHeal.TakeHealth(10.0f);
        Debug.Log("Health given");
    }
    //New bottle is created
    void CreateItem(Vector3 position)
    {
        GameObject bottle = Instantiate(bottlePrefab, position, Quaternion.identity);
        bottle.transform.localScale = new Vector3(1f, 1f, 1f);
        Debug.Log("New item created");
    }
    //generate random vetor with a range for x and z, as it need to be
    Vector3 VectorGenerator()
    {
        float randomX = Random.Range(-8f, 8f);
        float randomZ = Random.Range(-8f, 8f);
        return new Vector3(randomX, 2f, randomZ);
        Debug.Log("New position generated");
    }
    //when something collides with the boittle it suicides and creates a new one
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        CreateItem(VectorGenerator());
        Debug.Log("Item destroyed");

        // The object collided is called collidedObject
        GameObject collidedObject = collision.gameObject;

        // This checks that the object is tagged Toilet, and it is therefore a toilet
        if (collidedObject.CompareTag("Toilet"))
        {
            //The toilet is set to toilet
            Toilet toilet = collidedObject.GetComponent<Toilet>();

            // If it is a toilet the toilet is given health
            if (toilet != null)
            {
                GiveHealth(toilet);
            }
        }

    }
}