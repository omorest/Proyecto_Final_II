using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanzarGranada : MonoBehaviour
{
    public controladorDelegados controlador;

    public float fuerzaLanzamiento = 20f;
    public GameObject granadaObjeto;

    public GameObject desactivarPistola;
    public GameObject activarGranada;
    private GameObject desactivarPistolaScript;

    private int tieneGranada = 0;
    private bool puertaDestruida = false;
    private bool granadaActivada = false;

    void OnEnable()
    {
        controlador.recogerGranada += recogerGranada;
        controlador.destruirPuerta += destruirPuerta;
    }

    void OnDeseable()
    {
        controlador.recogerGranada -= recogerGranada;
        controlador.destruirPuerta -= destruirPuerta;
    }

    void recogerGranada()
    {
        tieneGranada += 1;
    }

    void destruirPuerta()
    {
        puertaDestruida = true;
        tieneGranada = 0;
    }

    void Update()
    {
        if (tieneGranada > 0)
        {
            if (puertaDestruida == false)
            {
                desactivarPistola.SetActive(false);
                activarGranada.SetActive(true);
                granadaActivada = true;
                desactivarPistolaScript = GameObject.FindWithTag("PlayerTag");
                desactivarPistolaScript.GetComponent<Shot>().enabled = false;
                
                if (Input.GetButtonDown("Fire1"))
                {
                    lanzarGranadaJugador();
                }
            }
        }
        else
        {
            if (granadaActivada == true)
            {
                desactivarPistola.SetActive(true);
                activarGranada.SetActive(false);
                desactivarPistolaScript = GameObject.FindWithTag("PlayerTag");
                desactivarPistolaScript.GetComponent<Shot>().enabled = true;
            }
        }
    }

    void lanzarGranadaJugador()
    {
        GameObject granada = Instantiate(granadaObjeto, transform.position, transform.rotation);
        Rigidbody rb = granada.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * fuerzaLanzamiento, ForceMode.VelocityChange);

        controlador.LanzarEliminarEfectoGranada();
        tieneGranada -= 1;
    }
}
