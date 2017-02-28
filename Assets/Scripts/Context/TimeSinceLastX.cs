using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSinceLastX : MonoBehaviour {

    private float _meal;
    private float _toilet;
    private float _rest;
    private float _drink;
    private float _shower;
 
    public float meal
    {
        get
        {
            return _meal;
        }
        set
        {
            _meal = value;
        }
    }

    public float drink
    {
        get
        {
            return _drink;
        }
        set
        {
            _drink = value;
        }
    }

    public float toilet
    {
        get
        {
            return _toilet;
        }
        set
        {
            _toilet = value;
        }
    }

    public float shower
    {
        get
        {
            return _shower;
        }
        set
        {
            _shower = value;
        }
    }

    public float rest
    {
        get
        {
            return _rest;
        }
        set
        {
            _rest = value;
        }
    }

    void Update()
    {
        meal += Time.deltaTime;
        drink += Time.deltaTime;
        shower += Time.deltaTime;
        toilet += Time.deltaTime;
        rest += Time.deltaTime;
    }
}
