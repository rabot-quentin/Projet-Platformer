using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealfBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealf(int healf )
    {
        slider.maxValue = healf;
        slider.value = healf; 
    }
    public void SetHealth(int health)
    {
        slider.value = health; 
    }
}
