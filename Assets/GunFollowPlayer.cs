using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFollowPlayer : MonoBehaviour {
  private Transform target;
  
  public Vector3 offset;
  [Range (0, 1)]
  public float lerpValue;

  private void Start() {
    target = GameObject.FindWithTag("PlayerTag").transform;
  }

  private void LateUpdate() {
    transform.position = Vector3.Lerp(transform.position, target.position + offset, lerpValue);
    transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);
  }
}
