using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveData : MonoBehaviour
{   
    public InputField nameBox;
    public Text nameText;
    public Text pointsText;
    // Start is called before the first frame update

    public void ClickStartButton()
    {
        PlayerPrefs.SetString("playername", nameBox.text);
        Debug.Log("Your name is " + PlayerPrefs.GetString("playername"));
        SceneManager.LoadScene("GameScene");
    }
    void Start()
    {
        nameText.text = PlayerPrefs.GetString("playername");
        pointsText.text = "Points: " + PlayerPrefs.GetInt("points");
    }

    public void ResetSavedGame()
    {
        PlayerPrefs.DeleteKey("playername");
        SceneManager.LoadScene("IntroScene");
    }
}
