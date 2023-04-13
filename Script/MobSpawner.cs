using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    public float timer;
    public GameObject enemy;
    float nextSpawn;
    public float spawnRate;


    // Update is called once per frame
    void Update()
    {
        spawner();
    }

    void spawner()
    {
        if(Time.time>nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            var mob = Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        }

    }
}
