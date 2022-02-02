using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camswitch : MonoBehaviour
{	
  public GameObject cam;
  public GameObject cam2;
  int state=0;
  
    // Start is called before the first frame update
    void Start()
    {
        cam.SetActive(true);
	cam2.SetActive(false);
	
    }

    // Update is called once per frame
    void Update()
    {	if(Input.GetKeyDown(KeyCode.Space))
	
        {
		if(state==0)
		{
		cam.SetActive(false);
		cam2.SetActive(true);
		state=1;
		}
		else
		{
		cam.SetActive(true);
		cam2.SetActive(false);
		state=0;
		}
	}
    }
}
