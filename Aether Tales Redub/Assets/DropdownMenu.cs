using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropdownMenu : MonoBehaviour
{
    Dropdown dropdown;
    public List<string> DefaultOptions;
    public string defaultOption;

    // Start is called before the first frame update
    void Start()
    {
        dropdown = GetComponent<Dropdown>();
        dropdown.AddOptions(DefaultOptions);
        dropdown.captionText.text = DefaultOptions[0];
        defaultOption = DefaultOptions[0];
        dropdown.value = 20;
    }
}
