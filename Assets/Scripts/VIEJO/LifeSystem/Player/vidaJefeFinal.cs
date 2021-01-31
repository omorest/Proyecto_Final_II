using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaJefeFinal : MonoBehaviour {
  public DelegateController controlador;

  public GameObject estrella;

  public int vida;
  private int vidaInicial = 500;
  private bool dead;
  private int factorVida = 100;

  void OnEnable()
  {
      controlador.getEnemyDamageEvent += quitarVidaTroll;
  }

  void OnDeseable()
  {
      controlador.getEnemyDamageEvent -= quitarVidaTroll;
  }

  // Start is called before the first frame update
  void Awake()
  {
      controlador = GameObject.FindWithTag("CameraRigTag").GetComponent<DelegateController>();

      vida = vidaInicial;
      dead = false;
  }

  // Update is called once per frame
  void Update()
  {
      if (vida <= 0 && dead == false)
      {
          GetComponent<Animator>().Play("Die");

          StartCoroutine(destruirEfecto());
          dead = true;
      }
  }

  IEnumerator destruirEfecto()
  {
      yield return new WaitForSeconds(3);
      estrella.SetActive(true);
      gameObject.SetActive(false);
  }

  public bool IsDead() {
      return dead;
  }

  private void quitarVidaTroll(string nombre, int daño)
  {
      if (gameObject.name == nombre)
      {
          if (vida > 0)
              vida -= daño;
      }
  }

  public int getVida()
  {
      return vida / factorVida;
  }
}
