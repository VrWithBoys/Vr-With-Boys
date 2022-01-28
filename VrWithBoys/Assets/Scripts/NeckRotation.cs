using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeckRotation : MonoBehaviour
{
    public Quaternion startQuaternioin;
    public Vector3 quaternionToVector;
    public Vector3 MoveVector;
    // Start is called before the first frame update
    void Start()
    {
        startQuaternioin = transform.rotation;     
    }
    
    void Update()
    {
        Debug.Log("Forward " + Camera.main.transform.forward);
        Debug.Log("Rotation: " + Camera.main.transform.rotation);
        Debug.Log("Angle: " + Camera.main.velocity);
        transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(Camera.main.transform.eulerAngles),Time.deltaTime*Camera.main.velocity[0]);
        transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(Camera.main.transform.eulerAngles),Time.deltaTime*Camera.main.velocity[1]);
        transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(Camera.main.transform.eulerAngles),Time.deltaTime*Camera.main.velocity[2]);
    }
}
