using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuButton: MonoBehaviour
{

    public Vector2 newPosition;
    public Vector2 DefaultPosition;
    public void Activate()
    {
        toNewPosition();
    }

    public void Deactivate()
    {
        toDefaultPosition();

    }

    public void toDefaultPosition()
    {
        Vector2.Lerp(this.transform.position, DefaultPosition, 3);
    }
    public void toNewPosition()
    {
        Vector2.Lerp(this.transform.position,newPosition, 3);
    } 
   

}
