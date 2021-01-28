using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyCharacter : MonoBehaviour {
  public float Speed = 5f;
  public float JumpHeight = 2f;
  public float GroundDistance = 0.2f;
  public float DashDistance = 5f;
  public LayerMask Ground;

  private Rigidbody body;
  private Vector3 move;
  private bool isGrounded;
  private Transform groundChecker;

  void Start() {
    body = GetComponent<Rigidbody>();
    groundChecker = GameObject.FindWithTag("GroundCheckTag").transform;
  }

  void Update() {
    isGrounded = Physics.CheckSphere(groundChecker.position, GroundDistance, Ground, QueryTriggerInteraction.Ignore);

    float axisX = Input.GetAxis("Horizontal");
    float axisZ = Input.GetAxis("Vertical");
    move = Camera.main.transform.right * axisX + Camera.main.transform.forward * axisZ;

    if (Input.GetButtonDown("Jump") && isGrounded) {
      body.AddForce(Vector3.up * Mathf.Sqrt(JumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
    }
  }

  void FixedUpdate() {
    body.MovePosition(body.position + move *  Speed * Time.fixedDeltaTime);
  }
}