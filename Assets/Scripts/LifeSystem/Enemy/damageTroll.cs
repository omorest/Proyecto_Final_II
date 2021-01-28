using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageTroll : MonoBehaviour
{
    public controladorDelegados controlador;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "bullet(Clone)")
        {
            controlador.LanzarVidaTroll();
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "bullet(Clone)")
        {
            controlador.LanzarVidaTroll();
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "bullet(Clone)")
        {
            controlador.LanzarVidaTroll();
        }
    }
}
