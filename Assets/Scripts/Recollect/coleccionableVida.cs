using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coleccionableVida : MonoBehaviour
{
    public controladorDelegados controlador;
    private int sumaColecciobleVida;
    private int sumaColecciobleDaño;

    AudioSource fuente;
    public AudioClip clip;
    public AudioClip sonidoEstrella;

    private void Start()
    {
        fuente = GetComponent<AudioSource> ();
        
        sumaColecciobleVida = 100;
        sumaColecciobleDaño = 25;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coleccionable")
        {
            fuente.clip = clip;
            fuente.Play();
            Destroy(collision.gameObject);
            controlador.LanzarColeccionableVida(sumaColecciobleVida);
        }

        if (collision.gameObject.tag == "coleccionableBala")
        {
            fuente.clip = clip;
            fuente.Play();
            Destroy(collision.gameObject);
            controlador.LanzarColeccionableDaño(sumaColecciobleDaño);
        }

        if (collision.gameObject.tag == "granada")
        {
            Destroy(collision.gameObject);
            controlador.recogerGranadaJugador();
        }

        if (collision.gameObject.name == "Estrella")
        {
            fuente.clip = sonidoEstrella;
            fuente.Play();
            Destroy(collision.gameObject);
        }
    }
}
