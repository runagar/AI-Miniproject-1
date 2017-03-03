using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToTarget : MonoBehaviour {

    public void MoveTo(Vector3 target)
    {
        NavMeshAgent agent = this.gameObject.GetComponent<NavMeshAgent>();
        agent.destination = target;
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
