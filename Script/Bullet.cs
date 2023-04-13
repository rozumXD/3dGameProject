using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 10;
    public float damage = 10;
    // Start is called before the first frame update
    void Awake()
    {
        Destroy(gameObject, life);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<EnemyHealth>(out EnemyHealth enemyComp))
        {
            
            enemyComp.takeDamage(damage);
            Debug.Log("Hit");
        }

        Destroy(gameObject);
    }
}
