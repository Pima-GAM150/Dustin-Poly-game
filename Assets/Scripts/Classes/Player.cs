using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour, IDamageable
{
    public int Health;
    public int Damage;
    public float ForwardSpeed,RotationSpeed;
    
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(ForwardSpeed*Vector3.forward* Time.deltaTime * Input.GetAxis("Vertical"));
        }
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Rotate(Vector3.up, RotationSpeed * Input.GetAxis("Horizontal")*Time.deltaTime);
        }

        if (Health <= 0)
        {
            Destroy(this);

            SceneManager.LoadScene("Ending");
        }
    }

    void IDamageable.TakeDamage(int damage)
    {
        Health -= damage;
    }
    
	
}
