using System.Collections;
using System.Collections.Generic;
using Apex.AI;
using UnityEngine;

public class PlayerContext : IAIContext {

	public PlayerContext(GameObject gameObject)
    {
        this.self = gameObject;
        this.observations = new List<GameObject>();
        this.myPosition = self.transform.position;
    }

    public GameObject self
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
