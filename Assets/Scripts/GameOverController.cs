using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{

    public MeterController meterController;
    public MainMenu mainMenu;
    public Text scoreText;
    private int score;
    private int highScore;

    public int soundEffectsOn = 1;

    private void Start()
    {

  
        score = (int) meterController.speedUpTime; 
        scoreText.text = ("Your Score: " + score);

        if(score > PlayerPrefs.GetInt("highscore",0)) {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    public void PlayGameAgain()
    {
        if (soundEffectsOn == PlayerPrefs.GetInt("soundEffects", 0))
        {
            FindObjectOfType<AudioManager>().Play("ButtonPressed");
        }
     
        SceneManager.LoadScene("Game");
        meterController.TimeRestart();

    }

    public void GoBackToMenu()
    {
       

        if (soundEffectsOn == PlayerPrefs.GetInt("soundEffects", 0))
        {
            FindObjectOfType<AudioManager>().Play("ButtonPressed");
        }
        SceneManager.LoadScene("Menu");
        meterController.TimeRestart();
    }
}
