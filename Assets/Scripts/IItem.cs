using UnityEngine;

//originally this code used both Start() and Update() however that was causing issues
public interface IItem
{
    void Give(Toilet ToiletToHeal);
    void CreateItem(Vector3 position);
    Vector3 VectorGenerator();
}
