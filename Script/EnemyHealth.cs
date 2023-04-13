using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject FloatingDmgText;
    public float health, maxHealth = 50f;           //Temp health that updates after taking dmg, Starting amount of health
    public Gun bullet;                              //Path to bullet obj

    public HealthBarScript hpBar;                   //Reference to HealthBarScript
    
    // Start is called before the first frame update
    void Start()
    {
         health = maxHealth;
    }
    public void takeDamage(float damageAmount)
    {
        //Taking damage, decreasing health
        health -= damageAmount;

        if(health <= 0)
        {
            Destroy(gameObject);
        }

        //Trigger floating DmgText
        showTextDmg(damageAmount);

        hpBar.UpdateHealthBar(health, maxHealth);

    }

    void showTextDmg(float damageAmount)
    {
       var go =  Instantiate(FloatingDmgText, transform.position, Quaternion.identity, transform);
       go.GetComponent<TextMesh>().text = damageAmount.ToString();
    }

}
