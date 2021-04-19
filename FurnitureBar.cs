using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FurnitureBar : MonoBehaviour
{
    public Slider slider;
    public Image fill;

    public void SetMinFurniture(int furniture)
    {
        slider.minValue = furniture;
        slider.value = furniture;
    }

    public void SetFurniture(int furniture)
    {
        slider.value = furniture;
    }
}