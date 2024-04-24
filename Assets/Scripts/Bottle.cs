using UnityEngine;
//originally this code used both Start() and Update() however that was causing issues
public class bottle : AItem
{
    public GameObject bottlePrefab;

    public override async void CreateItem(Vector3 position)
    {
        GameObject bottle = Instantiate(bottlePrefab, position, Quaternion.identity);
        bottle.transform.localScale = new Vector3(1f, 1f, 1f);
        Debug.Log("New item created");
    }

}