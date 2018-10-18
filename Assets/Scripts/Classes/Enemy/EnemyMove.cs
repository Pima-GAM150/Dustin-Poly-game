using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    private System.Random Rand;
    private Vector3 newPos;

    public NavMeshAgent Navigation;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Navigation.isActiveAndEnabled)
        {
            if (Navigation.isStopped)
            {
                newPos = new Vector3((float)Rand.NextDouble(), (float)Rand.NextDouble(), 1);
                Navigation.SetDestination(newPos);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!Navigation.isActiveAndEnabled)
        {
            Navigation.enabled = true;
        }
    }
}
