using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassFollowCharacter : MonoBehaviour
{
  Vector3 vector;
  private GameObject player;
  void Start() {
    Input.location.Start();
    player = GameObject.FindWithTag("MainCamera");
  }

  //La Brújula se moverá en la dirección del personaje
  void Update() {
    vector.z = player.transform.eulerAngles.y;
    transform.localEulerAngles = vector;
  }
}
