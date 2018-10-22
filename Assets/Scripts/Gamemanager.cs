using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    public MeterController meterController;

    float randY;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    public GameObject bird;
    public GameObject balloon;
    public GameObject plane;
    public GameObject spaceship;
    public GameObject background;

    private Camera currentView;


    Coroutine coroutine;

    EnemyBalloonStart balloonStart = EnemyBalloonStart.NoStart;
    enum EnemyBalloonStart { NoStart, Start, Started }

    EnemyBirdStart birdStart = EnemyBirdStart.NoStart;
    enum EnemyBirdStart { NoStart, Start, Started }

    EnemyPlaneStart planeStart = EnemyPlaneStart.NoStart;
    enum EnemyPlaneStart { NoStart, Start, Started }

    EnemySpaceshipStart spaceshipStart = EnemySpaceshipStart.NoStart;
    enum EnemySpaceshipStart { NoStart, Start, Started }

    EnemyHeartStart heartStart = EnemyHeartStart.NoStart;
    enum EnemyHeartStart { NoStart, Start, Started }

  
    void Update()
    {
        Enemies();

    }

    void Enemies()
    {
        
        if (meterController.speedUpTime > 5 && balloonStart == EnemyBalloonStart.NoStart)
        {
            balloonStart = EnemyBalloonStart.Start;
        }
       
        if (meterController.speedUpTime > 25 && birdStart == EnemyBirdStart.NoStart)
        {
            birdStart = EnemyBirdStart.Start;

        }
        if (meterController.speedUpTime > 60 && planeStart == EnemyPlaneStart.NoStart)
        {
            planeStart = EnemyPlaneStart.Start;
        }
        if (meterController.speedUpTime > 100 && spaceshipStart == EnemySpaceshipStart.NoStart)
        {
            spaceshipStart = EnemySpaceshipStart.Start;
        }



     
        if (balloonStart == EnemyBalloonStart.Start)
        {
            coroutine = StartCoroutine(StartBalloons());
            balloonStart = EnemyBalloonStart.Started;

        }
      
        if (birdStart == EnemyBirdStart.Start)
        {
            StopCoroutine(coroutine);
            coroutine = StartCoroutine(StartBirds());
            birdStart = EnemyBirdStart.Started;


        }
        if (planeStart == EnemyPlaneStart.Start)
        {
            StopCoroutine(coroutine);
            coroutine = StartCoroutine(StartPlanes());
            planeStart = EnemyPlaneStart.Started;

        }
        if (spaceshipStart == EnemySpaceshipStart.Start)
        {
            StopCoroutine(coroutine);
            coroutine = StartCoroutine(StartSpaceships());
            spaceshipStart = EnemySpaceshipStart.Started;

        }


    }



    IEnumerator StartBalloons()
    {
        while (true)
        {


            if (Time.time > nextSpawn)
            {
                
                nextSpawn = Time.time + spawnRate;
                randY = Random.Range(-4.60f, 3.80f);
                whereToSpawn = new Vector2(transform.position.x, randY);
                Instantiate(balloon, whereToSpawn, Quaternion.identity, background.transform);

            }

            yield return new WaitForSeconds(2f);

        }

    }


    IEnumerator StartBirds()
    {
        while (true)
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                randY = Random.Range(-4.60f, 3.80f);
                whereToSpawn = new Vector2(transform.position.x, randY);
                Instantiate(bird, whereToSpawn, Quaternion.identity, background.transform);

            }

            yield return new WaitForSeconds(1f);

        }

    }

    IEnumerator StartPlanes()
    {
        while (true)
        {

            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                randY = Random.Range(-4.60f, 3.80f);
                whereToSpawn = new Vector2(transform.position.x, randY);
                Instantiate(plane, whereToSpawn, Quaternion.identity, background.transform);
            }

            yield return new WaitForSeconds(0.8f);
        }

    }

    IEnumerator StartSpaceships()
    {
        while (true)
        {

            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                randY = Random.Range(-4.60f, 3.80f);
                whereToSpawn = new Vector2(transform.position.x, randY);
                Instantiate(spaceship, whereToSpawn, Quaternion.identity, background.transform);
            }

            yield return new WaitForSeconds(0.5f);

        }

    }




}
