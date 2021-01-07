using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
  private float xAxis, zAxis;
  private Vector3 movement;
  private CharacterController player;

  [Range (10, 30)]
  public float speed;

  private void Start() {
    player = GetComponent<CharacterController>();
    speed = 5f;
  }

  private void Update() {
    xAxis = Input.GetAxis("Horizontal");
    zAxis = Input.GetAxis("Vertical");

    Vector3 absoluteMovement = new Vector3(xAxis, 0.0f, zAxis);
    Quaternion directionCamera = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0);
    movement = directionCamera * absoluteMovement;
  }

  private void FixedUpdate() {
    player.Move(movement * speed * Time.deltaTime);
  }  
}
