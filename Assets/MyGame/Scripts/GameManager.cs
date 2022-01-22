using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   
    public Text scoreText;
    public Text highscoreText;
    public Text resultText;

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
            PlayerPrefs.SetInt("points", score);
        }
        
        if(collision.gameObject.CompareTag("Bad"))
        {
            Debug.Log("Jellyfish detected");
            score--;
            scoreText.text = score.ToString() + " Points";
            PlayerPrefs.SetInt("points", score);

        }
    }

    void Update()
    {   
        Debug.Log("Your score is " + PlayerPrefs.GetInt("points"));

        if(PlayerPrefs.GetInt("points") >= 3)
        {
            resultText.text = "You won!";
        }
        else
        {
            resultText.text = "You lost!";
        }
    }
}
