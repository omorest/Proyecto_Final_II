// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class eliminarEfectos : MonoBehaviour
// {
//     public DelegateController controlador;
//     private GameObject efecto;

//     private bool eliminar = false;

//     void OnEnable()
//     {
//         controlador.eliminarEfecto += activarEliminacion;
//     }

//     void OnDeseable()
//     {
//         controlador.eliminarEfecto -= activarEliminacion;
//     }

//     void activarEliminacion()
//     {
//         eliminar = true;
//     }

//     void Update()
//     {
//         if (eliminar == true)
//         {
//             StartCoroutine(destruirEfecto());
//         }
//     }

//     IEnumerator destruirEfecto()
//     {
//         yield return new WaitForSeconds(8);
//         efecto = GameObject.Find("BigExplosionEffect(Clone)");
//         Destroy(efecto);
//         eliminar = false;
//     }


// }
