﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SelfDestruct", 20f);
    }

    private void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
