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

    private void Start()
    {
        fuente = GetComponent<AudioSource> ();
        
        sumaColecciobleVida = 10;
        sumaColecciobleDaño = 10;
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
    }
}
