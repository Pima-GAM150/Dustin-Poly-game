using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour, IAttack
{
    public int Damage;
    public Animator AnimationController;

    private Enemy enemy;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            AnimationController.SetTrigger("Attack");
        }
    }
    
    void IAttack.Attack(GameObject Opponent)
    {
        enemy = Opponent.GetComponent<Enemy>();

        enemy.Health -= Damage;
    }

}
