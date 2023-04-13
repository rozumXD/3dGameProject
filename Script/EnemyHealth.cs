using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health, maxHealth = 50f;
    public Gun bullet;
    
    // Start is called before the first frame update
    void Start()
    {
         health = maxHealth;
    }
    public void takeDamage(float damageAmount)
    {
        health -= damageAmount;

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
