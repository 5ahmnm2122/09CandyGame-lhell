using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   
    public Text scoreText;
    public Text highscoreText;

    private GameObject good;
    private GameObject bad;
    int score = 0;

    void Start ()
    {
        scoreText.text = score.ToString() + " Points";

        PlayerPrefs.SetInt("points", score);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Good"))
        {
            Debug.Log("Burger detected");
            score++;
            scoreText.text = score.ToString() + " Points";
        }
        
        if(collision.gameObject.CompareTag("Bad"))
        {
            Debug.Log("Jellyfish detected");
            score--;
            scoreText.text = score.ToString() + " Points";

        }
    }
}
