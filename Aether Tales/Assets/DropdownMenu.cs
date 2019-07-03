using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropdownMenu : MonoBehaviour
{
    Dropdown dropdown;
    public string DefaultText;
    // Start is called before the first frame update
    void Start()
    {
        dropdown = GetComponent<Dropdown>();
        dropdown.captionText.text = DefaultText;
    }
}
