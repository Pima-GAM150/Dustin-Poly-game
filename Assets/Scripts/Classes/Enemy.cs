using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable, IAttack
{
    void IDamageable.TakeDamage(int damage)
    {

    }
    void IAttack.Attack()
    {

    }
}
