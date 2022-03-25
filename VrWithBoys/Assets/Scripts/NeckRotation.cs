using Mirror;
using UnityEngine;

public class NeckRotation : NetworkBehaviour
{
    public float lerpTime = 40;
    public Camera characterCam;
    
    void Update()
    {
        Debug.Log("Camera rotation2 "+ characterCam.transform.rotation);
        transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(characterCam.transform.eulerAngles),Time.deltaTime*lerpTime);
    }
}