using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOption : MonoBehaviour
{
    Vector2 RestPosition;
    public Vector2 ActivePosition;

    bool isComingIn = false;
    bool isLeavingOut = false;

    public void Start()
    {
        this.transform.localPosition = new Vector2(-1000,-1000);
        RestPosition = this.transform.localPosition;
        this.gameObject.SetActive(false);
        
    }
    public void Update()
    {
        if(isComingIn)
        {
            this.transform.localPosition = Vector2.Lerp(this.transform.localPosition,ActivePosition,.2f);
        }
    }
    public void toActive()
    {
        this.transform.localPosition = RestPosition;
        isComingIn = true;
        StartCoroutine(waitBeforeFullLoad());
    }
    public void toRest()
    {
       this.gameObject.SetActive(false);
    }

    public IEnumerator waitBeforeFullLoad()
    {
        yield return new WaitForSeconds(5);
        isComingIn = false;
    }
}
