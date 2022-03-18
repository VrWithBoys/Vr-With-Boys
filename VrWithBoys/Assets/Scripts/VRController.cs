using System.Collections;
using Google.XR.Cardboard;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Management;

public class VRController : MonoBehaviour
{    
    private const float _defaultFieldOfView = 60.0f;

    // Main camera from the scene.
    private Camera _mainCamera;

    public void Start(){
        StopXR();
    }
    public void Update()
    {
         
    }
 
    private void StopXR()
    {
        Debug.Log("Stopping XR...");
        XRGeneralSettings.Instance.Manager.StopSubsystems();
        Debug.Log("XR stopped.");

        Debug.Log("Deinitializing XR...");
        XRGeneralSettings.Instance.Manager.DeinitializeLoader();
        Debug.Log("XR deinitialized.");

        // _mainCamera.ResetAspect();
        // _mainCamera.fieldOfView = _defaultFieldOfView;
    }
}
