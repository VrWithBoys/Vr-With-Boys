using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeckRotation : MonoBehaviour
{
    public Quaternion startQuaternioin;
    public float lerpTime = 1;
    public bool rotate;
    float xInput;
    // Start is called before the first frame update
    void Start()
    {
        startQuaternioin = transform.rotation;
    }

    // public float speed = 100;
    
    // public GameObject chracterNeck;
    
    void Update()
    {
     if(rotate){
         transform.rotation = Quaternion.Lerp(transform.rotation,startQuaternioin,Time.deltaTime*lerpTime);
     }  
    }

    public void snapRotation(){
        transform.rotation = startQuaternioin;
    }
}
