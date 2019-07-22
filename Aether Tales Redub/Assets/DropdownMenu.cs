using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropdownMenu : MonoBehaviour
{
    Dropdown dropdown;
    public List<string> DefaultOptions;
    // Start is called before the first frame update
    void Start()
    {
        dropdown = GetComponent<Dropdown>();
        dropdown.AddOptions(DefaultOptions);
        dropdown.captionText.text = DefaultOptions[0];
        dropdown.value = 20;
    }

    void onEnable()
    {
        dropdown.value = 20;
        dropdown.captionText.text = dropdown.options[20].text;
        for(int i = 0; i<dropdown.onValueChanged.GetPersistentEventCount();i++)
        {
            dropdown.onValueChanged.Invoke(i);
        }
    }
}
