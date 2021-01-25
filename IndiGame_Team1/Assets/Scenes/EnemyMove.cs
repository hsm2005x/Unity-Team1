using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    NavMeshAgent navAgent;
    [SerializeField]
    Transform target;
    void Awake(){
        navAgent = GetComponent<NavMeshAgent>();
        Debug.Log("awake");
    }

      // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            navAgent.SetDestination(target.position);
        }
        Debug.Log("Update");
    }
}
