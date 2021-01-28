using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

  private string GAME_SCENE = "Game";
  public GameObject fadeEffect;

  IEnumerator ChangeAfter2SecondsCoroutine() {
    //Print the time of when the function is first called.
    fadeEffect.SetActive(true);

    Debug.Log("Started Coroutine at timestamp : " + Time.time);

    //yield on a new YieldInstruction that waits for 5 seconds.
    yield return new WaitForSeconds(2);

    //After we have waited 2 seconds print the time again.
    Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    //And load the scene
    //Application.LoadLevel("Game");  <-- This is correctly name of the scene

    SceneManager.LoadScene(GAME_SCENE);

  }

  public void PlayGame() {
    StartCoroutine(ChangeAfter2SecondsCoroutine());

    //fadeEffect.SetActive(true);
    //SceneManager.LoadScene(GAME_SCENE);
  }

  public void QuitGame() {
    Application.Quit();
  }
}
