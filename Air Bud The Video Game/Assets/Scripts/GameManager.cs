using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    private float timeRemaining = 60.0f;
    public TextMeshProUGUI timerText;
    public bool isGameActive;
    public Button restartButton;
    public GameObject hoop;
    public GameObject rim;
    

    private void Start()
    {
        isGameActive = true;
        AddToTimer(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive == true)
        {
            Timer();
        }
        if (timeRemaining < 0)
        {
            GameOver();
        }
    }

    public void AddToTimer(int timeToAdd)
    {
        timeRemaining += timeToAdd;
    }

    public void Timer()
    {
        timeRemaining -= Time.deltaTime;
        timerText.text = "Time: " + Mathf.Round(timeRemaining);
    }

    // Stop game, bring up game over text and restart button
    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
