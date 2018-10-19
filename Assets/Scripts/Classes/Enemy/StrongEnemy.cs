﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongEnemy : Enemy, IDamageable
{
    public int DamageMultiplyer;

    public EnemyAttack Attack;

    Enemy me;

    private void Start()
    {
        me = this.GetComponent<Enemy>();
        me.Damage *= DamageMultiplyer;
    }
    private void Update()
    {
        if (Health <= 0)
        {
            Die();
        }
    }
    void IDamageable.TakeDamage(int damage)
    {
        Health -= damage-3;
    }
}
