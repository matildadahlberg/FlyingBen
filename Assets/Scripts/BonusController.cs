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

    EnemyHeartStart heartStart = EnemyHeartStart.NoStart;
    enum EnemyHeartStart { NoStart, Start, Started }

    EnemyArrowUpStart arrowUpStart = EnemyArrowUpStart.NoStart;
    enum EnemyArrowUpStart { NoStart, Start, Started }

    EnemyArrowDownStart arrowDownStart = EnemyArrowDownStart.NoStart;
    enum EnemyArrowDownStart { NoStart, Start, Started }

    Coroutine coroutine;


    private void Update()
    {
        BonusObjects();
    }

    void BonusObjects(){

        if (meterController.speedUpTime > 70 && heartStart == EnemyHeartStart.NoStart)
        {
            heartStart = EnemyHeartStart.Start;
        }

        if (meterController.speedUpTime > 20 && arrowUpStart == EnemyArrowUpStart.NoStart)
        {
            arrowUpStart = EnemyArrowUpStart.Start;

        }
        if (meterController.speedUpTime > 55 && arrowDownStart == EnemyArrowDownStart.NoStart)
        {
            arrowDownStart = EnemyArrowDownStart.Start;
        }

        if (heartStart == EnemyHeartStart.Start)
        {
            coroutine = StartCoroutine(StartHearts());
            heartStart = EnemyHeartStart.Started;

        }
        if (arrowUpStart == EnemyArrowUpStart.Start)
        {
            coroutine = StartCoroutine(StartArrowUp());
            arrowUpStart = EnemyArrowUpStart.Started;

        }
        if (arrowDownStart == EnemyArrowDownStart.Start)
        {
            coroutine = StartCoroutine(StartArrowDown());
            arrowDownStart = EnemyArrowDownStart.Started;

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

            yield return new WaitForSeconds(40.0f);
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
