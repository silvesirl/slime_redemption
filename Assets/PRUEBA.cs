﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PRUEBA : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.y - 56 > transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}