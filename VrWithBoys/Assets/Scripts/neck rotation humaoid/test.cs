using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    public float lerpTime =40;
    public Camera cam;
    public Vector3 rotation;
    public GameObject neck;
    float x;
    float y;
    float z;
    
  
    Animator anim;
    
    void Start()
    {
       anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        //x = anim.GetBoneTransform (neck).localRotation.x;
       // y = anim.GetBoneTransform (neck).localRotation.y;
       // z = anim.GetBoneTransform (neck).localRotation.z;
        cam.transform.rotation=Quaternion.Lerp(transform.rotation,Quaternion.Euler(neck.transform.eulerAngles),Time.deltaTime*lerpTime);
        cam.transform.position=neck.transform.position;
      
    }
}
