using System.Security.AccessControl;
using UnityEngine;
using System;

public interface IAttack
{
    public void TakeStamina(Toilet BelongsTo, float Amount);
    public void TakeDamage(Toilet Opponent, float Amount);
    //Attack() is in its application asyncronous, however since no body is made in the interface the async keyword cannot be used
    public void Attack();
}
