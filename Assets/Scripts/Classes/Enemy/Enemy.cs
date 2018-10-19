using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public int Health;
    public int Damage;

    protected void Die()
    {
        Destroy(this.gameObject);
    }

    void IDamageable.TakeDamage(int damage)
    {
        Health -= damage;
    }
}
