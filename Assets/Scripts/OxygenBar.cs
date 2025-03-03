﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class OxygenBar : MonoBehaviour
{

    private Slider slider;
    public InformationManager iM;
    private Text textSliderValue;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        textSliderValue = GetComponent<Text>();
        ShowSliderValue();
        SetMaxOxygenLevel(iM.GetMaxOxygenLevel());
    }

    public void SetMaxOxygenLevel (float maxLevel)
    {
        slider.maxValue = maxLevel;
        slider.value = maxLevel; // Start with max!
  
    }

    public void SetOxygenLevel (float level)
    {
        slider.value = level;
    }
    public void ShowSliderValue () {
    	string sliderMessage = "OXYGEN LEVEL= " + slider.value;
    	textSliderValue.text = sliderMessage;
    }

    private void Update()
    {
        SetOxygenLevel(iM.GetOxygenLevel());
    }
}
