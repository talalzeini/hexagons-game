using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    public GameObject GameOverPanel;
    public GameObject Spawner;
    public Text finalScoreText;

    public void Spawn()
    {
        Spawner.SetActive(false);
    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);
        finalScoreText.text = FindObjectOfType<Spawner>().score.ToString();
    }

    public void Restart()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}




