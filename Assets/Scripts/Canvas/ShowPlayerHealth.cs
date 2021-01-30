using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPlayerHealth : MonoBehaviour {
  public Image health;
  private vidaJugador player;
  
  private void Start() {
    player = GameObject.FindWithTag("PlayerTag").GetComponent<vidaJugador>();
  }

  private void Update() {
    health.fillAmount = player.GetVida() / 100.0f;
  }
}
