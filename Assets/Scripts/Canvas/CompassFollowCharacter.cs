using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassFollowCharacter : MonoBehaviour {
  private Transform player;
  private Vector3 rotation;
  
  void Start() {
    player = Camera.main.transform;
    rotation = new Vector3(0, 0, 0);
  }


  //La Brújula se moverá en la dirección del personaje
  void Update() {
    rotation.z = Camera.main.transform.eulerAngles.y;
    transform.localEulerAngles = rotation;
  }
}
