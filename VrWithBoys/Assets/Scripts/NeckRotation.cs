using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeckRotation : MonoBehaviour
{
    public float lerpTime = 40;
    public GameObject cam;
    public GameObject neck;
  
    void Start()
    {
         
    }
    
    void Update()
    {
        neck.transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(cam.transform.eulerAngles),Time.deltaTime*lerpTime);
	

    }
}
