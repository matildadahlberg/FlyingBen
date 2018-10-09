using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeterController : MonoBehaviour
{

    public Text counterText;
    public float speedUp = 2.0f;
    float startTime;
    public int speedUpTime;


    private void Start()
    {
        counterText = GetComponent<Text>() as Text;

        TimeRestart();

    }

    public void TimeRestart()
    {
        startTime = Time.time;
    }


    void Update()
    {

        timeCounter();

    }

    public void timeCounter()
    {

        speedUpTime = (int)((Time.time - startTime) * speedUp);
        counterText.text = speedUpTime + " m";

    }




}
