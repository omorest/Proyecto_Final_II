using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour {
  private float xAxis, zAxis;
  private Vector3 movement;
  private CharacterController player;

  [Range (5, 30)]
  public float speed;

  private void Start() {
    player = GetComponent<CharacterController>();
  }

  // public float speed = 5;
  


  // void FixedUpdate() {
  //   velocity.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
  //   velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
  //   transform.Translate(velocity.x, 0, velocity.y);
  //   player.Move(movement * speed * Time.deltaTime)
  // }

  private void Update() {
    print(player);
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
