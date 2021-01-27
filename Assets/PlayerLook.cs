using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour {
  
  private Transform playerBody;
  private float sensibility = 100f;
  private float xRotation = 0f;

  private void Start() {
    playerBody = GameObject.FindWithTag("PlayerTag").transform;
  }

  private void Update() { 

    // Vector3 absoluteMovement = new Vector3(xAxis, 0.0f, zAxis);
    // Quaternion directionCamera = Quaternion.Euler(0, transform.eulerAngles.y, 0);
    // movement = directionCamera * absoluteMovement;

    // var x = transform.eulerAngles.y;
    // var x = Quaternion.Euler()
    // print(x);

    // playerBody.Rotate(0, x, 0);

    // print(Camera.main.transform.position);
    // print(Input.GetAxis("Mouse X"));

    // float xAxis = Input.GetAxis("Mouse X");
    // float yAxis = Input.GetAxis("Mouse Y");

    // xRotation -= yAxis;
    // xRotation = Mathf.Clamp(xRotation, -90f, 90f);

    // //transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

    // print(xAxis);
    // playerBody.Rotate(Vector3.up * xAxis);

    // playerBody.LookAt(playerBody.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);
    // Vector3 fwd = Camera.main.transform.forward;
    // playerBody.LookAt(fwd);
    // fwd.y = 0;
    // print(fwd);
    // playerBody.rotation = Quaternion.LookRotation(fwd);
  }

// private bool isRotating = false;

//   void Update () {
//       //Set your input right here to start the rotation
//       if (Input.GetKeyDown(KeyCode.Space))
//           isRotating = !isRotating; //Starts the rotation

//       if (isRotating) //Check if your game object is currently rotating
//           SetRotate(playerBody, transform);

//       //When your child game object and your camera have the same rotation.y value, it stops the rotation
//       if (playerBody.rotation.eulerAngles.y == transform.rotation.eulerAngles.y)
//           isRotating = !isRotating;
//   }
 
//   void SetRotate(Transform toRotate, Transform camera)
//   {
//       //You can call this function for any game object and any camera, just change the parameters when you call this function
//       toRotate.rotation = Quaternion.Lerp(toRotate.rotation, camera.rotation, 10 * Time.deltaTime);
//   }
}
