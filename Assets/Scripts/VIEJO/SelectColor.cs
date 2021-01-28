using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectColor : MonoBehaviour {
  private static Color DEFAULT_COLOR = Color.white;
  public static Color currentColor = DEFAULT_COLOR;

  public void setYellow() {
    currentColor = Color.yellow;
  }

  public void setBlue() {
    currentColor = Color.blue;
  }

  public void setRed() {
    currentColor = Color.red;
  }
}
