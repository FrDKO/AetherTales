using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExpandViewPort : MonoBehaviour
{
    RectTransform rect;

    public float XSize;
    public float YSize;
    void Start()
    {
     rect = GetComponent<RectTransform>();
        
    }

    void OnEnable()
    {
       rect.sizeDelta = new Vector2(XSize,YSize);
    }

}
