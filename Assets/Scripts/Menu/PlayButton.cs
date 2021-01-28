using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class PlayButton : MonoBehaviour, IGvrPointerHoverHandler {

  private string GAME_SCENE = "Game";
  public GameObject fadeEffect;
  public GameObject hideButton;
  public GameObject otherButton;

  IEnumerator ChangeAfter2SecondsCoroutine() {
    fadeEffect.SetActive(true);
    hideButton.SetActive(true);
    Destroy(otherButton);
    yield return new WaitForSeconds(2);
    SceneManager.LoadScene(GAME_SCENE);
  }

  public void Start() {
    ResetColor();
  }

  public void OnGvrPointerHover(PointerEventData eventData) {
    GetComponent<Renderer>().material.color = Color.red;
    if (Input.GetKeyDown(KeyCode.Return)) {
      StartCoroutine(ChangeAfter2SecondsCoroutine());
    }
  }

  public void ResetColor() {
    GetComponent<Renderer>().material.color = Color.blue;
  }
}

