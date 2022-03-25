using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerManager : NetworkBehaviour
{
    public GameObject playerCamera;
    public GameObject Head;
    void Start(){
        if(isLocalPlayer){
            playerCamera.SetActive(true);
            transform.position = transform.position + new Vector3(-1.12f,0,0);
        }
        else 
            playerCamera.SetActive(false);
    }
    void HandleMovement(){
        if(isLocalPlayer) {
            Debug.Log("Camera rotation "+ playerCamera.transform.rotation);
            Head.transform.rotation = Quaternion.Lerp(Head.transform.rotation,Quaternion.Euler(playerCamera.transform.eulerAngles),Time.deltaTime*40);
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
