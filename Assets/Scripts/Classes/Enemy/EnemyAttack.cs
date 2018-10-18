using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour, IAttack
{
    public int Damage;
    public Animator AnimationController;

    Player enemy;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AnimationController.SetTrigger("Attack");
        }
    }

    void IAttack.Attack(GameObject Opponent)
    {
        enemy = Opponent.GetComponent<Player>();

        enemy.Health -= Damage;
    }
}
