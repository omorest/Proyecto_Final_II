using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class granada : MonoBehaviour
{
    private float delay = 5f;

    public GameObject explosionEffect;
    private float radio = 5f;
    private float force = 200f;

    private float countdown;
    private bool hasExploded = false;
    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0 && hasExploded == false)
        {
            explotarGranada();
            hasExploded = true;
        }
    }

    void explotarGranada()
    {
        // Instantiate(explosionEffect, transform.position, transform.rotation);
        Collider[] colliders = Physics.OverlapSphere(transform.position, radio);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radio);
            }

            destruirEntrada destroy = nearbyObject.GetComponent<destruirEntrada>();
            if (destroy != null)
            {
                destroy.Destroy();
            }
        }
        
        Destroy(gameObject);
    }
}
