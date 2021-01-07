using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
  private float xAxis, zAxis;
  
  [Range (10, 50)]
  public float speed;

  private void Start() {
    speed = 50f;
  }

  private void Update() {
    Walk();
  }

  private void Walk() {
    xAxis = Input.GetAxis("Horizontal");
    zAxis = Input.GetAxis("Vertical");

    Vector3 absoluteMovement = new Vector3(xAxis, 0.0f, zAxis);
    Quaternion directionCamera = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0);
    Vector3 relativeMovement = directionCamera * absoluteMovement;

    transform.Translate(relativeMovement * speed * Time.deltaTime);
  }
}
