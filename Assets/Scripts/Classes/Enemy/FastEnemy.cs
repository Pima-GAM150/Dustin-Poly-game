using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastEnemy : Enemy, IDamageable
{
    public int SpeedMultiplyer;

    void IDamageable.TakeDamage(int damage)
    {
        Health -= damage;
    }

}
