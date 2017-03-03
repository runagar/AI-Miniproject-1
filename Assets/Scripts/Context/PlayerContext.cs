using System.Collections;
using System.Collections.Generic;
using Apex.AI;
using UnityEngine;
using UnityEngine.AI;

public class PlayerContext : IAIContext {
    
	public PlayerContext(PlayerContextProvider player)
    {
        this.self = player.gameObject;
        this.player = player;
        this.observations = new List<GameObject>();
        this.myPosition = self.transform.position;
        this.navAgent = self.GetComponent<NavMeshAgent>();
    }

    public PlayerContextProvider player
    {
        get;
        private set;
    }

    public GameObject self
    {
        get;
        private set;
    }

    public NavMeshAgent navAgent
    {
        get;
        private set;
    }

    public List<GameObject> observations
    {
        get;
        private set;
    }

    public Vector3 myPosition
    {
        get;
        private set;
    }
}
