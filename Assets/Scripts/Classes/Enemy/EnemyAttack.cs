using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Enemy TypeOfEnemy;

    private IDamageable enemy;

    private GameObject Opponent;

    private void OnCollisionEnter(Collision collision)
    {
        Opponent =  collision.gameObject;

        Attack();
    }

    private void Attack()
    {
        enemy = Opponent.GetComponent<Player>();
        if (enemy != null)
        {
            enemy.TakeDamage(TypeOfEnemy.Damage);
        }
    }
}
