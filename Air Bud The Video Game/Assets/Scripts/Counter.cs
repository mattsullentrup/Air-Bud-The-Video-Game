using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text ScoreText;
    public int Score = 0;

    private GameManager gameManager;
    public GameObject hoop;
    private MoveHoop moveHoop;

    public AudioClip woof;

    private AudioSource woofAudio;

    private void Start()
    {
        Score = 0;
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        moveHoop = hoop.GetComponent<MoveHoop>();
        woofAudio = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        moveHoop.AddSpeed(0.5f);
        Score += 1;
        ScoreText.text = "Score: " + Score;
        gameManager.AddToTimer(5);
        woofAudio.PlayOneShot(woof);
    }
}
