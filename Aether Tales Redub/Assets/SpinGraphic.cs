using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinGraphic : MonoBehaviour
{
    public float spinSpeed;
    void Update()
    {
        transform.Rotate(new Vector3(0,1*Time.deltaTime*spinSpeed));
    }
}
