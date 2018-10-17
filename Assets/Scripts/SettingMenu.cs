using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour {


    public GameObject backgroundON;
    public GameObject backgroundOFF;
    public GameObject soundON;
    public GameObject soundOFF;

    private void Awake()
    {
        

        if (PlayerPrefs.GetInt("soundEffects", 1) == 1)
        {
            soundON.SetActive(true);
            soundOFF.SetActive(false);
            
        } else {

            soundOFF.SetActive(true);
            soundON.SetActive(false);
            
        }

        if (PlayerPrefs.GetInt("backgroundMusic", 1) == 1)
        {
            backgroundON.SetActive(true);
            backgroundOFF.SetActive(false);

        } else {
            backgroundOFF.SetActive(true);
            backgroundON.SetActive(false);
        }
    }
}
