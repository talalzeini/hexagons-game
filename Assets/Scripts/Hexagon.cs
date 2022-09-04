﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{

    public Rigidbody2D rb;
    public Player player;
    public float shrinkSpeed = 3f;
    public float score;

    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 100f;
    }

    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed  * Time.deltaTime;
        if (transform.localScale.x <= 0.0003f)
        {
            FindObjectOfType<Spawner>().AddScore();
            Destroy(gameObject);
        }
    }

}
    
 
