using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPlayerPower : MonoBehaviour {
  public Image power;
  private vidaJugador player;
  
  private void Start() {
    player = GameObject.FindWithTag("PlayerTag").GetComponent<vidaJugador>();
  }

  private void Update() {
    power.fillAmount = player.GetDañoBala() / 100.0f;
  }
}
