using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuComponent : MonoBehaviour
{
    [Header("From what position do you want to fly in, and to where?")]
    public Vector2 RestPosition;
    public Vector2 ActivePosition;

    bool isComingIn = false;

    [Header("How fast do you want it to fly in? (Default is .1)")]
    public float flyInSpeed;


    public void Start()
    {
        this.transform.localPosition = RestPosition;
    }
    public void Update()
    {
        if(isComingIn)
        {
            if(flyInSpeed.Equals(0))
            this.transform.localPosition = Vector2.Lerp(this.transform.localPosition,ActivePosition,.1f);
            else
            this.transform.localPosition = Vector2.Lerp(this.transform.localPosition,ActivePosition,flyInSpeed);
            if(this.transform.localPosition.Equals(ActivePosition))
            {
                isComingIn = false;
            }
        }
    }
    public void toActive()
    {
        this.transform.localPosition = RestPosition;
        isComingIn = true;
    }
    public void toRest()
    {
       this.gameObject.SetActive(false);
    }
}
