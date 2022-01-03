using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class tuiseki : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;
    private Transform enemy;
    bool inArea = false;
    float time = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        enemy = GetComponent<Transform>();
    }

    void Update()
    {
        if(inArea == true)
        {
            if (time <= 10)
            {
                agent.destination = target.position;
                time += Time.deltaTime;
            }
            else
            {
                inArea = false;
                time = 0;
                gameObject.transform.position = new Vector3(36,-61,-52);                
            }
        }
        Debug.Log(time);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            inArea = true;
        }
    }
}
