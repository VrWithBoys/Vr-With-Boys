using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeckRotation : MonoBehaviour
{
    public Quaternion startQuaternioin;
    public Vector3 quaternionToVector;
    public Vector3 MoveVector;
    public float lerpTime = 40;
    void Start()
    {
         
    }
    
    void Update()
    {
        Debug.Log("Forward " + Camera.main.transform.forward);
        Debug.Log("Rotation: " + Camera.main.transform.rotation);
        Debug.Log("Angle: " + Camera.main.transform.eulerAngles);
        transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(Camera.main.transform.eulerAngles),Time.deltaTime*lerpTime);
    }
}
