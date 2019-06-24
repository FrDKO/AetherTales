using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropDownMenu : MonoBehaviour
{
    public string startLabel;
    void Start()
    {
        this.gameObject.GetComponent<Dropdown>().captionText.text = startLabel;
    }
}
