using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    [SerializeField] private Image _healthBarSpirte;    //Img of health bar sprite above mob
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    public void UpdateHealthBar(float currentHp, float maxHp){
        _healthBarSpirte.fillAmount = currentHp/maxHp;
    }

    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - cam.transform.position);
    }
    
}
