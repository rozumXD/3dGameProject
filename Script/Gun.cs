using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed;
    public float fireRate;
    float nextFire;
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
           spawner();
        }
        
    }

    void spawner()
    {
        if(Time.time>nextFire)
        {
            nextFire = Time.time + fireRate;
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
            
    }
}
