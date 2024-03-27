using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wanderer : MonoBehaviour
{
    public NavMeshAgent agent;
    private Vector3 destination;

    void Start()
    {
        destination = new Vector3(Random.Range(30, 45), 0f, Random.Range(-2, 6));
        agent.SetDestination(destination);
    }

    void Update()
    {
        if (agent.remainingDistance <= .5f)
        {
            destination = new Vector3(Random.Range(30, 45), 0f, Random.Range(-2, 6));
            agent.SetDestination(destination);
        }
    }


}
