using UnityEngine;
using UnityEngine.Scripting;

//originally this code used both Start() and Update() however that was causing issues

public class Cigar : AItem
{
    void Awake()
    {
        gameObject.GetComponent<Animator>().enabled = true;
    }

    public override void Give(Toilet ToiletToHeal)
    {
        ToiletToHeal.TakeStamina(10.0f);
        Debug.Log("Toilet given stamina by bottle");
    }
}
