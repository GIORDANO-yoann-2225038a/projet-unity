using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   public Slider slider;
   public Gradient gradient;
   public Image fill;


    public void SetMaxHealthBar(int health){
        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1f);

    }
    public void SetHealthBar(int health)
    {
        slider.value = health;
        fill.color= gradient.Evaluate(slider.normalizedValue);
    }

}
