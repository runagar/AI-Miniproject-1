using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToTarget : MonoBehaviour {

    NavMeshAgent agent;
    // Use this for initialization
    void Start () {
        agent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    public void MoveTo(Vector3 target)
    {
        agent.destination = target;
    }
}
