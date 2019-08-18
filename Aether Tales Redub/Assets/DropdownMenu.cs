using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropdownMenu : MonoBehaviour
{
    Dropdown dropdown;
    public string InitialDropdownName;
    public string Path;
    // Start is called before the first frame update
    void Start()
    {
        
        dropdown = GetComponent<Dropdown>();
        dropdown.options.Insert(0,new Dropdown.OptionData {text = InitialDropdownName});
        dropdown.captionText.text = InitialDropdownName;
    }
    void onEnable()
    {
        dropdown = GetComponent<Dropdown>();
        dropdown.options.Insert(0,new Dropdown.OptionData {text = InitialDropdownName});
        dropdown.captionText.text = InitialDropdownName;
    }
}
