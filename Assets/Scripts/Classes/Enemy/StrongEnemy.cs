using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongEnemy : Enemy, IDamageable
{
    public int DamageMultiplyer;
    public EnemyAttack Attack; 

    void IDamageable.TakeDamage(int damage)
    {
        Health -= damage-3;
    }
}
