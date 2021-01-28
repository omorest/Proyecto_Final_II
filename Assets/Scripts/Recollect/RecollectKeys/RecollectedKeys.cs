using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecollectedKeys : MonoBehaviour {
  public Text textCounterKeysRecollected;
  int numberOfKeysRecollected;
  void Start() {
    RecollectKeys.eventRecollectKeys += sumKeysRecollected;
    numberOfKeysRecollected = 0;
    textCounterKeysRecollected = GameObject.Find("Text").GetComponent<Text>();
  }

  void Update() {
    textCounterKeysRecollected.text = "Llaves recolectadas: " + numberOfKeysRecollected;
  }

  public void sumKeysRecollected() {
    numberOfKeysRecollected++;
  }
}
