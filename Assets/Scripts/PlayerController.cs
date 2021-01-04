using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
  private float xAxis, zAxis;
  public float speed;

  private void Start() {
    speed = 50f;
  }

  private void Update() {
    Walk();
  }

  private void Walk() {
    //xAxis = Input.GetAxis("Horizontal");
    //zAxis = Input.GetAxis("Vertical");

    xAxis = 0.1f;
    zAxis = 0.1f;

    Vector3 movement = new Vector3(xAxis, 0, zAxis);
    transform.Translate(movement * speed * Time.deltaTime);
  }
}
