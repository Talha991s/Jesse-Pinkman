using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyMovement : MonoBehaviour
{
    private Detection detect;
    private NavMeshAgent navMeshAgent;
    private Animator animator;
    private Transform target;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
        detect = GetComponent<Detection>();
        detect.OnDetect += Detect_OnDetect;
    }

    private void Detect_OnDetect(Transform target)
    {
        this.target = target;
       // navMeshAgent.SetDestination(target.position);
    }
    private void Update()
    {
        if( target !=null)
        {
            navMeshAgent.SetDestination(target.position);
            float speed = navMeshAgent.velocity.magnitude;
            animator.SetFloat("Speed", speed);
        }

    }
}
