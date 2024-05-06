using UnityEngine;
//originally this code used both Start() and Update() however that was causing issues

public class Bottle : AItem
{
    public override void Give(Toilet ToiletToHeal)
    {
        ToiletToHeal.TakeHealth(10.0f);
        Debug.Log("Toilet given helath by bottle");
    }
}

