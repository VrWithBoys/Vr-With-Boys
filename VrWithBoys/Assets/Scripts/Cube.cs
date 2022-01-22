using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
     Rigidbody cube;
    float xInput;
    float zInput;
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        cube = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space)){
        // Destroys gameObject on pressing Space
            //Destroy(gameObject);
        // Adds upwards force to cube
            cube.AddForce(Vector3.up*200);
        // Adds Velocity to object
            cube.velocity = Vector3.forward * 2f;    
        }

        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        cube.AddForce(xInput,0,zInput);
    }

    private void OnMouseDown(){
       // Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision) {
            
    }
    
}
