using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthBar : MonoBehaviour
{
    private Slider _healthBar;

    private void Awake()
    {
        _healthBar = GetComponent<Slider>();
    }

    public void SetMax(int maxHealth)
    {
        _healthBar.maxValue = maxHealth;
    }

    public void SetValue(int value)
    {
        _healthBar.value = value;
    }

    
}