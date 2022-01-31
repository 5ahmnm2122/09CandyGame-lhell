using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
     public Text resultText;

     public Text nameText;

     public Text pointText;


    void Start ()
    {
        nameText.text = PlayerPrefs.GetString("playername");
        pointText.text = PlayerPrefs.GetInt("points").ToString();
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
