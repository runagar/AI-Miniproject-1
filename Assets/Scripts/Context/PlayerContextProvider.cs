using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using Apex.AI.Components;

public class PlayerContextProvider : MonoBehaviour, IContextProvider {

    private IAIContext _context;

    private void Awake()
    {
        _context = new PlayerContext(this.gameObject);
    }

    public IAIContext GetContext(Guid aiID)
    {
        return _context;
    }
 
    public float _timeSinceLastMeal
    {
        get;
        private set;
    }

    public float _timeSinceLastDrink
    {
        get;
        private set;
    }

    public float _timeSinceLastShower
    {
        get;
        private set;
    }

    public float _timeSinceLastToilet
    {
        get;
        private set;
    }

    public float _timeSinceLastRest
    {
        get;
        private set;
    }
}
