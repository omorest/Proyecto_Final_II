using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaTroll : MonoBehaviour
{
    public controladorDelegados controlador;

    public int vida;
    private bool delete;
    private int factorVida = 100;

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
        delete = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (vida == 0 && delete == false)
        {
            Debug.Log("El troll ha muerto");
            Destroy(gameObject);
            delete = true;
        }
    }

    private void quitarVidaJugador()
    {
        if (vida > 0)
            vida -= 1;
    }

    public int getVida()
    {
        return vida / factorVida;
    }
}
