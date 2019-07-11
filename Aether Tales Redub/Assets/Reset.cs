using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reset : MonoBehaviour
{
    public Dropdown[] dropdowns;
    public Slider[] sliders;
    public InputField[] inputFields;
    // Start is called before the first frame update
    public void resetAll()
    {
        foreach(Dropdown x in dropdowns)
        {
           x.value = 20;
        }
        foreach(Slider x in sliders)
        {
            x.value = 0;
        }
        foreach(InputField x in inputFields)
        {
            x.text = "";
        }
    }
}
