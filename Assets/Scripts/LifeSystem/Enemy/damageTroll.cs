using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageTroll : MonoBehaviour
{
    public controladorDelegados controlador;
    private vidaJugador player;
    public int dañoBala;
    public int dañoChoqueJugador;

    private void Start() {
        player = GameObject.FindWithTag("PlayerTag").GetComponent<vidaJugador>();
        dañoChoqueJugador = 1;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bala")
        {
            dañoBala = player.GetDañoBala();
            controlador.LanzarVidaTroll(dañoBala);
        }

        if (collision.gameObject.tag == "PlayerTag")
        {
            controlador.LanzarVidaTroll(dañoChoqueJugador);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerTag")
        {
            controlador.LanzarVidaTroll(dañoChoqueJugador);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerTag")
        {
            controlador.LanzarVidaTroll(dañoChoqueJugador);
        }
    }
}
