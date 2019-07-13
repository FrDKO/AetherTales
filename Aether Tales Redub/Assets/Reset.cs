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
           x.value = 100;
           for(int i = 0; i < x.onValueChanged.GetPersistentEventCount();i++)
           {
               x.onValueChanged.Invoke(i);
           }
        }
        foreach(Slider x in sliders)
        {
            x.value = 0;
            for(int i = 0; i < x.onValueChanged.GetPersistentEventCount();i++)
           {
               x.onValueChanged.Invoke(i);
           }
        }
        foreach(InputField x in inputFields)
        {
            x.text = "";
            for(int i = 0; i < x.onValueChanged.GetPersistentEventCount();i++)
           {
               x.onValueChanged.Invoke(i.ToString());
           }
        }
    }
}
