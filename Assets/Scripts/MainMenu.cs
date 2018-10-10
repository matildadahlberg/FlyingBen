using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{

    private MeterController meterController;
    public Text highScoreText;
   

    private void Start()
    {
        
    }


    public void PlayGame()
    {

        SceneManager.LoadScene("Game");
        meterController.TimeRestart();
    }

}
