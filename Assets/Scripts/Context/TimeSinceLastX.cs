using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSinceLastX : MonoBehaviour {

    private float _meal;
    private float _toilet;
    private float _rest;
    private float _drink;
    private float _shower;

    Slider hungerSlider, thirstSlider, restSlider, hygieneSlider, bladderSlider;

    private void Start()
    {
        hungerSlider = GameObject.Find("Hunger").GetComponent<Slider>();
        thirstSlider = GameObject.Find("Thirst").GetComponent<Slider>();
        restSlider = GameObject.Find("Rest").GetComponent<Slider>();
        hygieneSlider = GameObject.Find("Hygiene").GetComponent<Slider>();
        bladderSlider = GameObject.Find("Bladder").GetComponent<Slider>();
    }

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
        meal += Time.deltaTime / 2;
        drink += Time.deltaTime / 2;
        shower += Time.deltaTime / 2;
        toilet += Time.deltaTime / 2;
        rest += Time.deltaTime / 2;

        if (meal > 20) meal = 20;
        if (drink > 20) drink = 20;
        if (shower > 30) shower = 30;
        if (toilet > 16) toilet = 16;
        if (rest > 40) rest = 40;

        hungerSlider.value = meal;
        thirstSlider.value = drink;
        restSlider.value = rest;
        hygieneSlider.value = shower;
        bladderSlider.value = toilet;
    }
}
