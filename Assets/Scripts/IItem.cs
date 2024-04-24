using UnityEngine;
//originally this code used both Start() and Update() however that was causing issues
public interface IItem
{
    void GiveHealth(Toilet ToiletToHeal);
    public void CreateItem(Vector3 position);
    public Vector3 VectorGenerator();
}
