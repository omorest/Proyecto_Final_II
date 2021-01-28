using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour {
  public float maxGroundDistance = 0.3f;
  public bool isGrounded;

  void LateUpdate() {
    isGrounded = Physics.Raycast(transform.position, Vector3.down, maxGroundDistance);
  }
}
