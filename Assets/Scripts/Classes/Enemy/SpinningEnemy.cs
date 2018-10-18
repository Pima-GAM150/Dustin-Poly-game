using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningEnemy : Enemy, IDamageable
{
    
    void IDamageable.TakeDamage(int damage)
    {
        Health -= damage;
    }
}
