using UnityEngine;
//originally this code used both Start() and Update() however that was causing issues

public class Cigar : AItem
{
    public override void Give(Toilet ToiletToHeal)
    {
        ToiletToHeal.TakeStamina(10.0f);
        Debug.Log("Toilet given stamina by bottle");
    }
}


