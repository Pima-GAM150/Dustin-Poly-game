using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
    
    public int SpawnSpeed;

    public GameObject SpinningEnemy;
    public GameObject StrongEnemy;
    public GameObject FastEnemy;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while(true)
        {
            yield return new WaitForSeconds(SpawnSpeed);
            
            Instantiate(FastEnemy);
            Instantiate(SpinningEnemy);
            Instantiate(StrongEnemy);
        }
    }
}
