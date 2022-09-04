using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public GameManager manager;
    public GameObject effect;
    public GameObject score;
    public GameObject Spawner;
    public Text gameScoreText;
    public float movement;
    public float moveSpeed;
    private float ScreenWidth;

    void Start ()
    {
        ScreenWidth = Screen.width;
    }

    public void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameManager>().GameOver();
        Destroy(gameObject);
        Instantiate(effect, transform.position, Quaternion.identity);
    }
}



   

     
