using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{

    private Player Player;
    public NavMeshAgent Navigation;

    private void Start()
    {
        Player = FindObjectOfType<Player>();

        StartCoroutine(FindPlayer());
    }

    IEnumerator FindPlayer()
    {
        while(true)
        {
            yield return new WaitForSeconds(3);

            Navigation.SetDestination(Player.gameObject.transform.position);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!Navigation.isActiveAndEnabled)
        {
            Navigation.enabled = true;

            Navigation.SetDestination(Player.gameObject.transform.position);
        }
    }
}
