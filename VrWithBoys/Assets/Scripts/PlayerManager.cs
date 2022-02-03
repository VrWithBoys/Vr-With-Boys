using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerManager : NetworkBehaviour
{
    void HandleMovement(){
        if(isLocalPlayer){
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal*0.1f, 0,moveVertical*0.1f);
            transform.position = transform.position + movement;
        }
    }
    void Update(){
        HandleMovement(); 
    }
}
