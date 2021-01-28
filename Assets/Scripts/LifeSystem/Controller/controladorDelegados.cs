using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorDelegados : MonoBehaviour
{
    public delegate void impactoJugadorVida();

    public event impactoJugadorVida restarVidaJugador;
    public event impactoJugadorVida restarVidaTroll;

    public void LanzarVidaJugador()
    {
        if (restarVidaJugador != null)
        {
            restarVidaJugador();
        }
    }

    public void LanzarVidaTroll()
    {
        if (restarVidaTroll != null)
        {
            restarVidaTroll();
        }
    }
}
