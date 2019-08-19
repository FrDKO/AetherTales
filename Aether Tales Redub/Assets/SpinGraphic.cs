using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
public class SpinGraphic : MonoBehaviour
{
    public float spinSpeed;
    public Vector3 rotationAxis;

    [ContextMenu("Reset")]
    void Reset()
    {
        this.transform.rotation = Quaternion.identity;
    }
    void Update()
    {
        transform.Rotate(rotationAxis*spinSpeed*Time.deltaTime);
    }

    


    
}
