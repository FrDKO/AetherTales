using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InputFieldComponent : MonoBehaviour
{
    
    public void OnEnable()
    {
        GetComponent<InputField>().text = "";
    }
    
}
