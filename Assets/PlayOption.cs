// // using System.Collections;
// // using System.Collections.Generic;
// // using UnityEngine;

// // public class PlayOption : MonoBehaviour {
// //   private void Update() {
// //     // print("HOLAAAAAAAAA");
// //     print(transform.position);
// //     if (Input.GetKeyDown(KeyCode.Return)) {
// //       print("EPALEEEEEEE");
// //     }
// //   }
// // }

//Attach this script to the GameObject you would like to have mouse hovering detected on
//This script outputs a message to the Console when the mouse pointer is currently detected hovering over the GameObject and also when the pointer leaves.

using UnityEngine;
// using UnityEngine.EventSystems;

public class PlayOption : MonoBehaviour {

    public Transform dest;

    // You should already set this via the Inspector
    [SerializeField] private Rigidbody _rigidbody;


    // Called every frame while the mouse stays over this object
    private void OnMouseOver() 
    {
        print("SOBRE");

        if (Input.GetKeyDown(KeyCode.Return)) 
        {
          print("TE la comiste");

            // whatever shall happen every frame while mouse over and mouse button 0 stays pressed
        }
    }

    public void Porfi() {
      print("HOLA");
    }
}