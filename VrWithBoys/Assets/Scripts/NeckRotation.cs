using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeckRotation : MonoBehaviour
{
    public float lerpTime = 40;
    void Start()
    {
         
    }
    
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(Camera.main.transform.eulerAngles),Time.deltaTime*lerpTime);
    }
}
