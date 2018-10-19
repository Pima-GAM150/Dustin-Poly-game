using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningEnemy : Enemy, IDamageable
{
    private void Update()
    {
        if (Health <= 0)
        {
            Die();
        }
    }
    void IDamageable.TakeDamage(int damage)
    {
        Health -= damage;
    }
}
