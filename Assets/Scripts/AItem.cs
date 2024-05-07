using Unity.VisualScripting;
using UnityEngine;

abstract public class AItem : MonoBehaviour, IItem
{
    public GameObject ItemPrefab;

    public virtual void Give(Toilet toilet) { }

    public virtual void CreateItem(Vector3 position)
    {
        Debug.Log("New item created");
        GameObject Cigar = Instantiate(ItemPrefab, position, Quaternion.identity);
        Cigar.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    public virtual Vector3 VectorGenerator()
    {
        float randomX = Random.Range(-8f, 8f);
        float randomZ = Random.Range(-8f, 8f);
        return new Vector3(randomX, 2f, randomZ);
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        CreateItem(VectorGenerator());
        Debug.Log("Item destroyed");

        GameObject collidedObject = collision.gameObject;

        if (collidedObject.CompareTag("Toilet"))
        {
            Toilet toilet = collidedObject.GetComponent<Toilet>();

            if (toilet != null)
            {
                Debug.Log("Trying to heal Toilet");
                Give(toilet);
            }
        }
    }
}
