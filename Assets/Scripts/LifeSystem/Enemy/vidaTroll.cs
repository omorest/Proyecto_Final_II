using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaTroll : MonoBehaviour
{
    public controladorDelegados controlador;

    public int vida;
    private bool dead;
    private int factorVida = 100;

    void OnEnable()
    {
        controlador.restarVidaTroll += quitarVidaTroll;
    }

    void OnDeseable()
    {
        controlador.restarVidaTroll -= quitarVidaTroll;
    }

    // Start is called before the first frame update
    void Start()
    {
        vida = 100;
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (vida <= 0 && dead == false)
        {
            Debug.Log("El troll ha muerto");
            GetComponent<Animator>().Play("Die");

            // Destroy(gameObject);
            dead = true;
        }
    }

    public bool IsDead() {
        return dead;
    }

    private void quitarVidaTroll(int daño)
    {
        if (vida > 0)
            vida -= daño;
    }

    public int getVida()
    {
        return vida / factorVida;
    }
}
