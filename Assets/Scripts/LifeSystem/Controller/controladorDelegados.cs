using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorDelegados : MonoBehaviour
{
    public delegate void impactoJugadorVida(int damage);
    public delegate void impactoJugadorTroll(int damage);

    public event impactoJugadorVida restarVidaJugador;
    public event impactoJugadorTroll restarVidaTroll;

    public delegate void coleccionableVidaJugador(int sumaVida);

    public event coleccionableVidaJugador sumarVidaJugador;
    public event coleccionableVidaJugador sumarDañoJugador;

    public void LanzarVidaJugador()
    {
        if (restarVidaJugador != null)
        {
            restarVidaJugador(0);
        }
    }

    public void LanzarVidaTroll(int daño)
    {
        if (restarVidaTroll != null)
        {
            restarVidaTroll(daño);
        }
    }

    public void LanzarColeccionableVida(int sumaVida)
    {
        if (sumarVidaJugador != null)
        {
            sumarVidaJugador(sumaVida);
        }
    }

    public void LanzarColeccionableDaño(int sumaDaño)
    {
        if (sumarDañoJugador != null)
        {
            sumarDañoJugador(sumaDaño);
        }
    }
}
