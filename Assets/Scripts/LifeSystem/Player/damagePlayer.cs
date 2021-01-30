using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagePlayer : MonoBehaviour
{
    public controladorDelegados controlador;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Troll")
        {
            controlador.LanzarVidaJugador();
        }

        if (collision.gameObject.tag == "dragon")
        {
            controlador.LanzarVidaJugador();
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Troll")
        {
            controlador.LanzarVidaJugador();
        }

        if (collision.gameObject.tag == "dragon")
        {
            controlador.LanzarVidaJugador();
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Troll")
        {
            controlador.LanzarVidaJugador();
        }

        if (collision.gameObject.tag == "dragon")
        {
            controlador.LanzarVidaJugador();
        }
    }
}
