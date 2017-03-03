using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using Apex.AI.Components;

public class PlayerContextProvider : MonoBehaviour, IContextProvider {

    private IAIContext _context;
    public List<float> needScores;
    public MoveToTarget _moveScript;
    TimeSinceLastX timeScript;

    private void Awake()
    {
        _context = new PlayerContext(this);
        _moveScript = this.gameObject.GetComponent<MoveToTarget>();
        timeScript = this.gameObject.GetComponent<TimeSinceLastX>();

    }

    public IAIContext GetContext(Guid aiID)
    {
        return _context;
    }
    
    public void FulfillHunger()
    {
        timeScript.meal = 0;

    }
    public void FulfillThirst()
    {
        timeScript.drink = 0;
    }
    public void FulfillRest()
    {
        timeScript.rest = 0;
    }
    public void FulfillToilet()
    {
        timeScript.toilet = 0;
    }
    public void FulfillHygiene()
    {
        timeScript.shower = 0;
    }

    public void MoveTo(Vector3 target)
    {
        _moveScript.MoveTo(target);
    }
    
}
