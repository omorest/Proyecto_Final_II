using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCubes : MonoBehaviour {
  private static Text conterText;

  private void Start() {
    conterText = GameObject.FindWithTag("cubesCounter").GetComponent<Text>();
    conterText.text = "Número de Cubos: " + GetCubes.numberOfCubesCollected;
  }

  private void Update() {
    conterText.text = "Número de Cubos: " + GetCubes.numberOfCubesCollected;
  }
}
