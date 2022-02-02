using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsUp : MonoBehaviour
{
	public Camera cam;
	public GameObject left;
	public GameObject right;
     
     float i=164F;
     float j=164F;
	int p =0;
	
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()	
    {
		
    if((cam.transform.eulerAngles.z>=10 && cam.transform.eulerAngles.z<150))
		{left.transform.rotation = Quaternion.Euler(i,0,0);
		if(i>-21)
		{
		 i=i-0.4F;
		}
		}
    if(!(cam.transform.eulerAngles.z>=10 && cam.transform.eulerAngles.z<150))
		{left.transform.rotation = Quaternion.Euler(i,0,0);
		if(i<150)
{
		 i=i+0.4F;
}
		}
if((cam.transform.eulerAngles.z<=350 && cam.transform.eulerAngles.z>210))
		{right.transform.rotation = Quaternion.Euler(j,0,0);
		if(j>-21)
		{
		 j=j-0.4F;
		}
		}
        if(!(cam.transform.eulerAngles.z<=350 && cam.transform.eulerAngles.z>210))
		{right.transform.rotation = Quaternion.Euler(j,0,0);
		if(j<150)
{
		 j=j+0.4F;
}
		}	
    
	
	
	if(Input.GetKey(KeyCode.Q))
		{
		cam.transform.rotation = Quaternion.Euler(0,0,p);
		p=p-1;
		}
	
    }
}
