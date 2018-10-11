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

        SceneManager.LoadScene("Game");
        meterController.TimeRestart();
    }

}
