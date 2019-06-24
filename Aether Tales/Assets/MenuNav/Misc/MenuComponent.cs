using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuComponent : MonoBehaviour
{
    public Vector2 RestPosition;
    public Vector2 ActivePosition;

    bool isComingIn = false;
    bool isLeavingOut = false;

    public void Start()
    {
        this.transform.localPosition = RestPosition;
    }
    public void Update()
    {
        if(isComingIn)
        {
            this.transform.localPosition = Vector2.Lerp(this.transform.localPosition,ActivePosition,.06f);
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
