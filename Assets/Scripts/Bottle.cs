using UnityEngine;
//originally this code used both Start() and Update() however that was causing issues

public class Bottle : AItem
{
    public GameObject BottlePrefab;
    public override void Give(Toilet ToiletToHeal)
    {
        ToiletToHeal.TakeHealth(10.0f);
        Debug.Log("Toilet given helath by bottle");
    }
    public override void CreateItem(Vector3 position)
    {
        GameObject Bottle = Instantiate(BottlePrefab, position, Quaternion.identity);
        Bottle.transform.localScale = new Vector3(1f, 1f, 1f);
    }
}

