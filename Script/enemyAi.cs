using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyAi : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent agent;
    public LayerMask whatIsPlayer, whatIsGround;

    //Attacking 
    public float timeBetweenAttacks;
    bool playerInSightRange, playerInAttackRange;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChasePlayer();
    }

    private void Awake()
    {
        player = GameObject.Find("HeroBox").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }
}
