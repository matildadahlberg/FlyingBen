using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{

    public MeterController meterController;

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
