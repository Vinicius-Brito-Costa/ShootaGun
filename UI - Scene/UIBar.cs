using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UIEssentials/Bar")]
public class UIBar : MonoBehaviour
{
    public string name;
    Image bar;
    float originalValue, currentValue;

    void Awake()
    {
        bar = GetComponent<Image>();
    }
    public float Get()
    {
        return currentValue;
    }
    public void Set(float value)
    {
        originalValue = value;
        currentValue = originalValue;
        bar.fillAmount = porcentageCount(value, 0);
    }
    public void Add(float addedValue)
    {
        if(bar == null) return;
        var hp = bar.fillAmount;
        currentValue += addedValue;
        if(currentValue > originalValue) bar.fillAmount = hp;
        else bar.fillAmount = porcentageCount(currentValue, originalValue);
    }
    public void Subtract(float subtractedValue)
    {
        if(bar == null) return;
        var hp = bar.fillAmount;
        currentValue -= subtractedValue;
        if(currentValue < 0) bar.fillAmount -= hp;
        else bar.fillAmount = porcentageCount(currentValue, originalValue);
    }
    float porcentageCount(float value, float value2)
    {
        return value * (100 / 100) / 100;
    }
}
