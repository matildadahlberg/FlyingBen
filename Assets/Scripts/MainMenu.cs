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
    private int soundFXon;
    private int backgroundMusic;
  




    private void Start()
    {
        
        
        mainHighScore = PlayerPrefs.GetInt("highscore", 0);

        highScoreText.text = ("Your HighScore: " + mainHighScore);


            FindObjectOfType<AudioManager>().Play("ButtonPressed");

            FindObjectOfType<AudioManager>().Play("BackgroundMusic");

        

    }


    public void PlayGame()
    {
        if (soundFXon == PlayerPrefs.GetInt("soundEffects", 0))
        {
            FindObjectOfType<AudioManager>().Play("ButtonPressed");
        }

        SceneManager.LoadScene("Game");
      //  meterController.TimeRestart();


    }


    public void SoundEffectsOn(){


        soundFXon = 1;
        PlayerPrefs.SetInt("soundEffects", soundFXon);  
        //FindObjectOfType<AudioManager>().Play("ButtonPressed");
        Debug.Log("SOUND ON " + soundFXon);
       


    }

    public void SoundEffectsOff()
    {


        soundFXon = 0;
        PlayerPrefs.SetInt("soundEffects", soundFXon);
        //FindObjectOfType<AudioManager>().Stop("ButtonPressed");
        Debug.Log("SOUNF OFF " + soundFXon);

    }

    public void BackgroundMusicStop()
    {


        backgroundMusic = 0;
        PlayerPrefs.SetInt("backgroundMusic", backgroundMusic);
        FindObjectOfType<AudioManager>().Stop("BackgroundMusic");
        Debug.Log("BackgroundSOUNF OFF " + backgroundMusic);

    }

    public void BackgroundMusicPlay()
    {
        
        backgroundMusic = 1;
        PlayerPrefs.SetInt("backgroundMusic", backgroundMusic);
        FindObjectOfType<AudioManager>().Play("BackgroundMusic");
        Debug.Log("BackgroundSOUND ON " + backgroundMusic);

       
    }

    public void SoundButtonEffect(){

        if (soundFXon == PlayerPrefs.GetInt("soundEffects", 0))
        {
            FindObjectOfType<AudioManager>().Play("ButtonPressed");
        }

        

    }



}
