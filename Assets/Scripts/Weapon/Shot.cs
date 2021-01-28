﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
  public GameObject bullet;
  public Transform spawnPoint;

  public float shotForce = 5000;
  public float shotRate = 0.5f;
  public float shotRateTime = 0;

  // Update is called once per frame
  void Update() {
    if (Input.GetButtonDown("Fire1")) { //botón izquiero del botón 
        if (Time.time > shotRateTime) {
          GameObject newBullet;
          newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);

          newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);

          shotRateTime = Time.time + shotRate;

          Destroy(newBullet, 1.5f);    
        }
    }
  }
}
