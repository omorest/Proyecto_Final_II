﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eliminarBala : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
