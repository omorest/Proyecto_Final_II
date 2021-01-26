using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

  private string GAME_SCENE = "Game";

  public void PlayGame() {
    SceneManager.LoadScene(GAME_SCENE);
  }

  public void QuitGame() {
    Application.Quit();
  }
}
