using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3 : MonoBehaviour {

  private CharacterController controller;
  
  private float gravity = -9.18f * 2;
  private float speed = 12f;
  private float jumpHeight = 3f;

  private Transform groundCheck;
  private float groundDistance = 0.4f;
  public LayerMask groundMask;

  private Vector3 velocity;
  private bool isGrounded;

  private void Start() {
    controller = GetComponent<CharacterController>();
    groundCheck = GameObject.FindWithTag("GroundCheckTag").transform;
  }

  private void Update() {
    isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

    if (isGrounded && velocity.y < 0) {
      velocity.y = -2f;
    }

    float xAxis = Input.GetAxis("Horizontal");
    float zAxis = Input.GetAxis("Vertical");

    // Movimiento x, z
    Vector3 move = Camera.main.transform.right * xAxis + Camera.main.transform.forward * zAxis;
    controller.Move(move * speed * Time.deltaTime);

    // Saltar
    if (Input.GetButtonDown("Jump") && (isGrounded)) {
      velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
    }

    // Movimiento y
    velocity.y += gravity * Time.deltaTime;
    controller.Move(velocity * Time.deltaTime);

  }
}
