﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement5 : MonoBehaviour {
  public float speed = 5;
  Vector2 velocity;

  void FixedUpdate() {
    velocity.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
    velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    transform.Translate(velocity.x, 0, velocity.y);
  }
}
