using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;



public class MainMenu : MonoBehaviour
{
    
    public Text highScoreText;
    private int mainHighScore;

  

    private void Start()
    {
         
        mainHighScore = PlayerPrefs.GetInt("highscore", 0);

        highScoreText.text = ("Your HighScore: " + mainHighScore);


        
        if (PlayerPrefs.GetInt("soundEffects", -1) == -1) {
            PlayerPrefs.SetInt("soundEffects", 1);
            FindObjectOfType<AudioManager>().Play("ButtonPressed");
        }

        if (PlayerPrefs.GetInt("backgroundMusic", -1) == -1)
        {
            PlayerPrefs.SetInt("backgroundMusic", 1);
            FindObjectOfType<AudioManager>().Play("BackgroundMusic");
        }

        if (PlayerPrefs.GetInt("soundEffects", 1) == 1)
        {
            FindObjectOfType<AudioManager>().Play("ButtonPressed");
        } 

        if (PlayerPrefs.GetInt("backgroundMusic", 1) == 1)
        {
            
            FindObjectOfType<AudioManager>().Play("BackgroundMusic");
        }

    }


    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }


    public void SoundEffectsOn(){
     
        PlayerPrefs.SetInt("soundEffects", 1);  
        FindObjectOfType<AudioManager>().Play("ButtonPressed");
        Debug.Log("SOUND ON " + 1);
      
    }

    public void SoundEffectsOff()
    {
        PlayerPrefs.SetInt("soundEffects", 0);
        FindObjectOfType<AudioManager>().Stop("ButtonPressed");
        Debug.Log("SOUNF OFF " + 0);

    }

    public void BackgroundMusicPlay()
    {
        PlayerPrefs.SetInt("backgroundMusic", 1);
        FindObjectOfType<AudioManager>().Play("BackgroundMusic");
        Debug.Log("BackgroundSOUND ON " );
    }

    public void BackgroundMusicStop()
    {
        
        PlayerPrefs.SetInt("backgroundMusic", 0);
        FindObjectOfType<AudioManager>().Stop("BackgroundMusic");
        Debug.Log("BackgroundSOUNF OFF " );
    }

   

    public void SoundButtonEffect(){

        if (1 == PlayerPrefs.GetInt("soundEffects", 0))
        {
            FindObjectOfType<AudioManager>().Play("ButtonPressed");
        }
    }
}
