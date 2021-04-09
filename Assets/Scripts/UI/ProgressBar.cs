using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;
 
    public void SetMaxColletibles(int collect)
    {
        slider.maxValue = 10;
        slider.value = collect;
    }
    public void Collected(int collect)
    {
        slider.value = collect;
    }
}
