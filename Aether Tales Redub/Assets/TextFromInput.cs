﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextFromInput : MonoBehaviour
{

    Text cardText;

    public Text newText;
    void Start()
    {
        cardText = GetComponent<Text>();
    }
    void Update()
    {
        if(newText!=null)
        cardText.text = newText.text;
    }

    public void setText(Text text)
    {
        cardText.text = text.text;
    }
}