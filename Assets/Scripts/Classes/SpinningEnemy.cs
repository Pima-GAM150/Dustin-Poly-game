using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningEnemy : Enemy, IDamageable
{
    public int RotationSpeed;

    public void Spin()
    {

    }
    void IDamageable.TakeDamage(int damage)
    {
        Health -= damage;
    }
}
