using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;



public class MainMenu : MonoBehaviour
{

   // private MeterController meterController;
    public Text highScoreText;
    private int mainHighScore;
    public int soundFXon;
    public int sounfEffectsOn = 1;


    private void Start()
    {
        mainHighScore = PlayerPrefs.GetInt("highscore", 0);

        highScoreText.text = ("Your HighScore: " + mainHighScore);

        if (sounfEffectsOn == PlayerPrefs.GetInt("soundEffects", 0))
        {
            FindObjectOfType<AudioManager>().Play("ButtonPressed");
            FindObjectOfType<AudioManager>().Play("BackgroundMusic");
        }

    }


    public void PlayGame()
    {
        if (sounfEffectsOn == PlayerPrefs.GetInt("soundEffects", 0))
        {
            FindObjectOfType<AudioManager>().Play("ButtonPressed");
        }

        SceneManager.LoadScene("Game");
      //  meterController.TimeRestart();


    }


    public void SoundEffectsOn(){

        Debug.Log("SOUND ON");
        soundFXon = 1;
        PlayerPrefs.SetInt("soundEffects", soundFXon);        
    }

    public void SoundEffectsOff()
    {

        Debug.Log("SOUNF OFF");
        soundFXon = 0;
        PlayerPrefs.SetInt("soundEffects", soundFXon);
    }

    public void BackgroundMusicStop(){

        FindObjectOfType<AudioManager>().Stop("BackgroundMusic");

    }

    public void BackgroundMusicPlay()
    {
        FindObjectOfType<AudioManager>().Play("BackgroundMusic");
       
    }

    public void SoundButtonEffect(){

        if (sounfEffectsOn == PlayerPrefs.GetInt("soundEffects", 0))
        {
            FindObjectOfType<AudioManager>().Play("ButtonPressed");
        }

        

    }



}
