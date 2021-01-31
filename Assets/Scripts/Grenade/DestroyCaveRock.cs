using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCaveRock : MonoBehaviour {
  private DelegateController controller;
  private GameObject cave;

  private void Awake() {
    controller = GameObject.FindWithTag("CameraRigTag").GetComponent<DelegateController>();
    cave = GameObject.FindWithTag("CaveTag");
  }
  
  public void Destroy() {
    cave.SetActive(true);
    controller.GrenadeDestroysCaveEntry();
    Destroy(gameObject);
  }
}
