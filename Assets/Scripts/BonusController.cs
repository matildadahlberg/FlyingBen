using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusController : MonoBehaviour {

    public GameObject heart;
    public GameObject arrowUp;
    public GameObject arrowDown;
    public MeterController meterController;
   

    float randX;
    Vector2 whereToSpawn;
    float nextSpawn = 0.0f;

    //private void Start()
    //{
    //    if (meterController.speedUpTime == 10 )
    //    {
    //        StartCoroutine(StartHearts());
    //    }

    //    StartCoroutine(StartArrowDown());
    //    StartCoroutine(StartArrowUp());
    //}

    private void Update()
    {

        if (meterController.speedUpTime > 10)
        {
            StartCoroutine(StartHearts());
        }
        if (meterController.speedUpTime > 10)
        {
            StartCoroutine(StartArrowDown());
        }
        if (meterController.speedUpTime > 10)
        {
            StartCoroutine(StartArrowUp());
        }

    }


    IEnumerator StartHearts()
    {
        while (true)
        {

            if (Time.time > nextSpawn)
            {
                randX = Random.Range(-2f, 2.0f);
                whereToSpawn = new Vector2(randX, transform.position.y);
                Instantiate(heart, whereToSpawn, Quaternion.identity);
            }

            yield return new WaitForSeconds(5.0f);
        }

    }

    IEnumerator StartArrowUp()
    {
        while (true)
        {

            if (Time.time > nextSpawn)
            {
                randX = Random.Range(-2f, 2.0f);
                whereToSpawn = new Vector2(randX, transform.position.y);
                Instantiate(arrowUp, whereToSpawn, Quaternion.identity);
            }

            yield return new WaitForSeconds(20.0f);
        }

    }

    IEnumerator StartArrowDown()
    {
        while (true)
        {

            if (Time.time > nextSpawn)
            {
                randX = Random.Range(-2f, 2.0f);
                whereToSpawn = new Vector2(randX, transform.position.y);
                Instantiate(arrowDown, whereToSpawn, Quaternion.identity);
            }

            yield return new WaitForSeconds(50.0f);
        }

    }


}
