using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int Damage;

    private IDamageable enemy;

    public GameObject Opponent;

    private void OnCollisionEnter(Collision collision)
    {
        Opponent = collision.rigidbody.gameObject;

        Attack();
    }

    private void Attack()
    {
        enemy = Opponent.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(Damage);
        }
    }

}
