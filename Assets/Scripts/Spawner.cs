using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameManager manager;
    public GameObject player;
    public GameObject hexagon;
    public Text scoreText;
    public int score;
    private float nextTimeToSpawn;
    private float spawnRate = 0.5f;

    public void Update()
    {
        if (Time.time >= nextTimeToSpawn && player != null)
        {
            Instantiate(hexagon, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
        else if(player == null){
            hexagon = null;
        }
    }

    public void AddScore()
    {
        if(player != null)
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}


    
