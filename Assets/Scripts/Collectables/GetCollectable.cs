using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCollectable : MonoBehaviour {
  private DelegateController controller;

  private int lifeIncrease;
  private int powerIncrease;

  AudioSource audioSource;
  public AudioClip itemSound;
  public AudioClip starSound;

  private void Start() {
    controller = GameObject.FindWithTag("CameraRigTag").GetComponent<DelegateController>();
    audioSource = GetComponent<AudioSource>();
    
    lifeIncrease = 100;
    powerIncrease = 25;
  }

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "IncreaseLifeTag") {
      audioSource.clip = itemSound;
      audioSource.Play();

      Destroy(collision.gameObject);
      controller.ExecuteLifeCollectible(lifeIncrease);
    }

    if (collision.gameObject.tag == "IncreasePowerTag") {
      audioSource.clip = itemSound;
      audioSource.Play();

      Destroy(collision.gameObject);
      controller.ExecutePowerCollectible(powerIncrease);
    }

    if (collision.gameObject.tag == "GrenadeTag") {
      Destroy(collision.gameObject);
      controller.PlayerPicksUpGrenade();
    }

    // Revisar
    if (collision.gameObject.name == "Estrella") {
      audioSource.clip = starSound;
      audioSource.Play();

      Destroy(collision.gameObject);
    }
  }
}
