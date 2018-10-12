using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{

    private MeterController meterController;
    public Text highScoreText;
    private int mainHighScore;
   

    private void Start()
    {
        mainHighScore = PlayerPrefs.GetInt("highscore", 0);

        highScoreText.text = ("Your HighScore: " + mainHighScore);
        
    }


    public void PlayGame()
    {
        FindObjectOfType<AudioManager>().Play("ButtonPressed");
        SceneManager.LoadScene("Game");
        meterController.TimeRestart();
    }

    public void SettingsButton()
    {
        FindObjectOfType<AudioManager>().Play("ButtonPressed");
    }



}
