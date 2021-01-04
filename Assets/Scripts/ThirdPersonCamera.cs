using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {
  private Transform target;
  
  public Vector3 offset;
  [Range (0, 1)]
  public float lerpValue;

  private void Start() {
    target = GameObject.FindWithTag("MainCharacterTag").transform;
  }

  private void LateUpdate() {
    transform.position = Vector3.Lerp(transform.position, target.position + offset, lerpValue);
  }
}
