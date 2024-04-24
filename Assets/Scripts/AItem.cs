using UnityEngine;
//originally this code used both Start() and Update() however that was causing issues
abstract public class AItem : MonoBehaviour, IItem
{
    public virtual void GiveHealth(Toilet ToiletToHeal)
    {
        ToiletToHeal.TakeHealth(10.0f);
        Debug.Log("Health given");
    }
    public virtual void CreateItem(Vector3 position)
    {
        Debug.Log("New item created");
    }
    //generates random vetor with a range for x and z, as it need to be
    public virtual Vector3 VectorGenerator()
    {
        float randomX = Random.Range(-8f, 8f);
        float randomZ = Random.Range(-8f, 8f);

        return new Vector3(randomX, 2f, randomZ);
    }
    //when something collides with the boittle it suicides and creates a new one

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        CreateItem(VectorGenerator());
        Debug.Log("Item destroyed");
        // The object collided is called collidedObject
        GameObject collidedObject = collision.gameObject;

        // This check that the object is tagged Toilet, and it is therefore a toilet
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
