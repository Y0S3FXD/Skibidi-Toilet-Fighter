using UnityEngine;

//originally this code used both Start() and Update() however that was causing issues
public interface IAttack
{
    void PerformAttack();
}
