using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OptionMenu : MonoBehaviour
{
    [Header("What UI elements should be disabled upon Loading?")]

    [Header("Buttons")]
    public List<Button> buttonsForDisable = new List<Button>();

    
    void OnEnable()
    {
        foreach(Button b in buttonsForDisable)
            b.interactable = false;
    }
}
