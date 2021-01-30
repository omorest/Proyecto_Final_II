using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorDelegados : MonoBehaviour
{
    public delegate void impactoJugadorVida(int damage);
    public delegate void impactoJugadorTroll(string nombre, int damage);

    public event impactoJugadorVida restarVidaJugador;
    public event impactoJugadorTroll restarVidaTroll;

    public delegate void coleccionableVidaJugador(int sumaVida);

    public event coleccionableVidaJugador sumarVidaJugador;
    public event coleccionableVidaJugador sumarDañoJugador;

    public delegate void eliminarEfectoGranada();

    public event eliminarEfectoGranada eliminarEfecto;
    public event eliminarEfectoGranada recogerGranada;
    public event eliminarEfectoGranada destruirPuerta;

    public void LanzarVidaJugador()
    {
        if (restarVidaJugador != null)
        {
            restarVidaJugador(100);
        }
    }

    public void LanzarVidaTroll(string nombre, int daño)
    {
        if (restarVidaTroll != null)
        {
            restarVidaTroll(nombre, daño);
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

    public void LanzarEliminarEfectoGranada()
    {
        if (eliminarEfecto != null)
        {
            eliminarEfecto();
        }
    }

    public void recogerGranadaJugador()
    {
        if (recogerGranada != null)
        {
            recogerGranada();
        }
    }

    public void destruirPuertaCueva()
    {
        print("Dentro");
        if (destruirPuerta != null)
        {
            destruirPuerta();
        }
    }
}
