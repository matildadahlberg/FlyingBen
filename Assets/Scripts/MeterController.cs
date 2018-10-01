using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeterController : MonoBehaviour {
    
    public Text counterText;
    public float speedUp = 2.5f;




    private void Start()
    {
        counterText = GetComponent<Text>() as Text;
    }


    void Update () {

        timeCounter();

	}

    public void timeCounter(){
       // Time.timeScale = speedUp;

        int speedUpTime = (int)(Time.time * speedUp);
        counterText.text = speedUpTime + " m";

    }




}
