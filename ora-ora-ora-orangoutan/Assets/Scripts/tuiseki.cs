using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class tuiseki : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;
    private Transform enemy;
    bool hit = false;
    float downtime = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        enemy = GetComponent<Transform>();
    }

    void Update()
    {
        if (hit == false)
        {
            agent.destination = target.position;
        }
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            hit = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            hit = false;
        }
    }
}
