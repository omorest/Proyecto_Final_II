using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

  private GameObject player;
  public float distanceBetweenObjects = 3f;
  public Rigidbody rb;
  // Transform transform;
  void Start() {
    rb = GetComponent<Rigidbody>();
    player = GameObject.Find("Player");
  }

  void Update() {  
    float distance = Vector3.Distance(transform.position, player.transform.position);
    
    if (distance <= distanceBetweenObjects) {
      // Vector3 direction = transform.position - player.transform.position;  
      // rb.AddForce(player.transform.position * 1f * Time.deltaTime);  
      transform.LookAt(player.transform);
      rb.AddForce(transform.forward * 50f);
      GetComponent<Animator>().Play("Run");
    }
  }
}