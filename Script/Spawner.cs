using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    public float spawnRadius = 7, time = 5f;   //Distance mobs spawns from player, Time beetewn spawns
    public GameObject[] mobs;                  //Table that contains the mobs


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAnEnemy());
    }

    IEnumerator SpawnAnEnemy()
    {
        Vector2 spawnPos = GameObject.Find("Hero").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;
        spawnPos.y = 5;

        Instantiate(mobs[Random.Range(0, mobs.Length)], spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(time);

        StartCoroutine(SpawnAnEnemy());
    }
}
