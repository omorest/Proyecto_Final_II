using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desactivarMundo : MonoBehaviour
{
    private bool entrandoCueva = false;
    public GameObject terreno;

    void OnCollisionEnter(Collision collision)
    {
        // if (collision.gameObject.tag == "PlayerTag")
        // {
        //     if (entrandoCueva == false)
        //     {
        //         entrandoCueva = true;
        //         terreno.SetActive(false);
        //         // Destroy(terreno);
        //     }
        //     else
        //     {
        //         entrandoCueva = false;
        //         terreno.SetActive(true);
        //     }
        // }
    }
}
