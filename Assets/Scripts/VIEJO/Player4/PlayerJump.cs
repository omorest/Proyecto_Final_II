using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {

  public CheckGround groundCheck;
  private Rigidbody rigidbody;

  private float jumpStrength = 2;
  private event System.Action Jumped;

  void Start() {
    rigidbody = GetComponent<Rigidbody>();
  }

  void LateUpdate() {
    if (Input.GetButtonDown("Jump") && groundCheck.isGrounded) {
      // rigidbody.AddForce(Vector3.up * 100 * jumpStrength);
      // Jumped?.Invoke();
      var y = Mathf.Sqrt(jumpStrength * -2f * 9.81f);
      transform.Translate(0, 0, 0);
    }
  }
}
