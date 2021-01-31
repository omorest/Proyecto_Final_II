using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cargarTerreno : MonoBehaviour
{
    private bool sliendodoCueva = false;
    public GameObject terreno;

    void OnCollisionEnter(Collision collision)
    {
        // if (collision.gameObject.tag == "PlayerTag")
        // {
        //     terreno.SetActive(true);
        // }
    }
}
