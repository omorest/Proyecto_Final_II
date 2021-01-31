using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecollectKeys : MonoBehaviour {
  public delegate void MethodDelegateRecollectKeys();
  public static event MethodDelegateRecollectKeys eventRecollectKeys;
  
  int numberOfKeys;
  void Start() {
    numberOfKeys = 0;
  }

  private void OnCollisionEnter(Collision other) {
    if (other.gameObject.tag == "Keys") {
      Destroy(other.gameObject);
      numberOfKeys++;  
      eventRecollectKeys();           
    }
  }
}
