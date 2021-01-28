using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCubes : MonoBehaviour {
  public static int numberOfCubesCollected;

  private void Start() {
    numberOfCubesCollected = 0;
  }

  public void Collect() {
    numberOfCubesCollected ++;
    Destroy(gameObject);
  }
}
