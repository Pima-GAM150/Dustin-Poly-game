using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FastEnemy : Enemy, IDamageable
{
    public int SpeedMultiplyer;

    public NavMeshAgent Navigation;

    private void Start()
    {
        Navigation.speed *= SpeedMultiplyer;
    }

    void IDamageable.TakeDamage(int damage)
    {
        Health -= damage;
    }

}
