using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class RigControl : MonoBehaviour {
  public GameObject humanoid;
  public GameObject cam;
  public Vector3 bodyRotation = new Vector3(0,0,0);
  HumanBodyBones head;
  Animator animator;
  
  
  void Start () {
    head = HumanBodyBones.Head;
    animator = humanoid.GetComponent<Animator>();
    
  }
  void LateUpdate () {
                           
    animator.GetBoneTransform(head).rotation = cam.transform.rotation;
    cam.transform.position = animator.GetBoneTransform(head).position;
    

  }
}