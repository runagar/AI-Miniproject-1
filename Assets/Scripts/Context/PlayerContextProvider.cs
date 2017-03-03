using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using Apex.AI.Components;

public class PlayerContextProvider : MonoBehaviour, IContextProvider {

    private IAIContext _context;
    public List<float> needScores;


    private void Awake()
    {
        _context = new PlayerContext(this);

        needScores = new List<float>();
        for (int i = 0; i < 5; i++) needScores.Add(0f);
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

    
    public void FulfillHunger()
    {
        _timeSinceLastMeal = 0;
    }
    public void FulfillThirst()
    {
        _timeSinceLastDrink = 0;
    }
    public void FulfillRest()
    {
        _timeSinceLastRest = 0;
    }
    public void FulfillToilet()
    {
        _timeSinceLastToilet = 0;
    }
    public void FulfillHygiene()
    {
        _timeSinceLastShower = 0;
    }

    
}
