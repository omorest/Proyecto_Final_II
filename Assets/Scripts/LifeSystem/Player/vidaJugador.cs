using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaJugador : MonoBehaviour
{
    public controladorDelegados controlador;

    public int vida;
    public int vidaInicial;
    public int vidaTotal;
    private bool muerto;
    private int factorVida = 10;
    public int dañoBala = 50;

    void OnEnable()
    {
        controlador.restarVidaJugador += quitarVidaJugador;
        controlador.sumarVidaJugador += sumarVidaJugador;
        controlador.sumarDañoJugador += sumarDañoJugador;
    }

    void OnDeseable()
    {
        controlador.restarVidaJugador -= quitarVidaJugador;
        controlador.sumarVidaJugador -= sumarVidaJugador;
        controlador.sumarDañoJugador -= sumarDañoJugador;
    }

    // Start is called before the first frame update
    void Start()
    {
        vidaTotal = 1000;
        vidaInicial = 500;
        vida = vidaInicial;
        muerto = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (vida == 0 && muerto == false)
        {
            muerto = true;
        }
    }

    private void quitarVidaJugador(int damage)
    {
        if (vida > 0)
            vida--;
    }

    private void sumarDañoJugador(int sumaDaño)
    {
        dañoBala += sumaDaño;
    }

    private void sumarVidaJugador(int sumaVida)
    {
        if (vida + sumaVida <= vidaTotal)
        {
            vida += sumaVida;
        }
        else
        {
            int vidaRestante = vidaTotal - vida;

            if (sumaVida > vidaRestante)
            {
                vida += vidaRestante;
            }
        }
    }

    public int GetVida()
    {
        return vida / factorVida;
    }

    public int GetDañoBala()
    {
        return dañoBala;
    }
}
