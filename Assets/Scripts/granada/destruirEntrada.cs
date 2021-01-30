using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirEntrada : MonoBehaviour
{
    public controladorDelegados controlador;
    public GameObject cueva;
    public void Destroy()
    {
        cueva.SetActive(true);
        controlador.destruirPuertaCueva();
        Destroy(gameObject);
    }
}
