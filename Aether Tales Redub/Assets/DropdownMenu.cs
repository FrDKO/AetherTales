﻿using System.Collections;
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
    void OnEnable()
    {
        dropdown.options.Insert(0,new Dropdown.OptionData {text = InitialDropdownName});
        
        var Listeners = dropdown.onValueChanged;
        dropdown.value = 0;

        dropdown.captionText.text = InitialDropdownName;
    }
    void OnDisable()
    {
        dropdown.options.RemoveAt(0);
    }
}