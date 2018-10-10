using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{

    public MeterController meterController;

    public Text scoreText;
    public int score;
    public int highScore;



private void Start()
    {
        score = meterController.speedUpTime; 
        scoreText.text = ("Your Score: " + score);

        highScore = PlayerPrefs.GetInt("highscore", highScore);

  
    }

    private void Update()
    {
        if(score > highScore){
            highScore = score;
            scoreText.text = "Your Score: " + score;

            PlayerPrefs.SetInt("highscore", highScore);
        }
    }

    public void PlayGameAgain()
    {

        SceneManager.LoadScene("Game");
        meterController.TimeRestart();


    }

    public void GoBackToMenu()
    {

        SceneManager.LoadScene("Menu");
        meterController.TimeRestart();


    }


}
