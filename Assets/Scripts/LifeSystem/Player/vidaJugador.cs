using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaJugador : MonoBehaviour
{
    public controladorDelegados controlador;

    public int vida;
    private bool muerto;
    private int factorVida = 10;

    void OnEnable()
    {
        controlador.restarVidaJugador += quitarVidaJugador;
    }

    void OnDeseable()
    {
        controlador.restarVidaJugador -= quitarVidaJugador;
    }

    // Start is called before the first frame update
    void Start()
    {
        vida = 1000;
        muerto = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (vida == 0 && muerto == false)
        {
            Debug.Log("Has muerto");
            muerto = true;
        }
    }

    private void quitarVidaJugador()
    {
        if (vida > 0)
            vida--;
        //Debug.Log("Pierdo vida: " + vida);
    }

    public int GetVida()
    {
        return vida / factorVida;
    }
}
