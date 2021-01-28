using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
  
  public void Change() {
    Renderer renderer = GetComponent<Renderer>();
    Color newColor = SelectColor.currentColor;
    renderer.material.color = newColor;
  }
}
