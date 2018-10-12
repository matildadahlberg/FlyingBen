using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeterController : MonoBehaviour
{

    public Text counterText;
    public float speedUp = 2.0f;
    float startTime;
    public float speedUpTime = 0;


    private void Start()
    {
        counterText = GetComponent<Text>() as Text;

        TimeRestart();

    }

    public void TimeRestart()
    {
        speedUpTime = 0;
        startTime = Time.time;
    }


    void Update()
    {

        speedUpTime += Time.deltaTime * speedUp;
        counterText.text = (int)speedUpTime + " m";

    }

}
