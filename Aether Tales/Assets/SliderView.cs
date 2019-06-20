using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderView : MonoBehaviour
{
    public void displaySliderData(Slider slider)
    {
        this.GetComponent<Text>().text = slider.value.ToString(); 
    }
}
