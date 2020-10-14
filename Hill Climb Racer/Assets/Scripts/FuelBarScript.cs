using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelBarScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void setMaxFuel(float fuel)
    {
        slider.maxValue = fuel;
        slider.value = fuel;
        fill.color = gradient.Evaluate(1f);
    }
    public void SetFuel(float fuel)
    {
        slider.value = fuel;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
