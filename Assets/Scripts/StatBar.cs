/*
 * Code obtained and derived from "How to make a HEALTH BAR in Unity!" by
 * Brackeys on YouTube
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatBar : MonoBehaviour
{
    public Slider slider;
    // public Gradient gradient;
    // public Image fill;

    public void SetBarMax(int maxValue)
    {
        slider.maxValue = maxValue;
        slider.value = maxValue;

        // fill.color = gradient.Evaluate(1f);
    }
    public void SetBarValue(int value)
    {
        slider.value = value;

        // fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
