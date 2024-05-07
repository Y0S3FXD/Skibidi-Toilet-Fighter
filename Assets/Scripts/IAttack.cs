using System.Security.AccessControl;
using UnityEngine;
using System;

public interface IAttack
{
    public void TakeStamina(Toilet BelongsTo, float Amount);
    public void TakeDamage(Toilet Opponent, float Amount);
    public void Attack();
}
