using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderComponent : MonoBehaviour
{
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    void onEnable()
    {
        slider.value = 0;
        for(int i = 0; i< slider.onValueChanged.GetPersistentEventCount();i++)
        {
            slider.onValueChanged.Invoke(i);
        }
    }
}
