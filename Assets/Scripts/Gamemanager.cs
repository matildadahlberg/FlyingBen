using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public Player player;
    public LifeController lifeController;

    public GameObject bird;
    public GameObject balloon;
    public GameObject plane;
    public GameObject spaceship;


    EnemyBalloonStart balloonStart = EnemyBalloonStart.NoStart;
    enum EnemyBalloonStart { NoStart, Start, Started }

    EnemyBirdStart birdStart = EnemyBirdStart.NoStart;
    enum EnemyBirdStart { NoStart, Start, Started }

    EnemyPlaneStart planeStart = EnemyPlaneStart.NoStart;
    enum EnemyPlaneStart { NoStart, Start, Started }

    EnemySpaceshipStart spaceshipStart = EnemySpaceshipStart.NoStart;
    enum EnemySpaceshipStart { NoStart, Start, Started }


    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        Enemies();

    }

    void Enemies(){
        int speedUpTime = (int)(Time.time * 2.5);

        //enemies();
        if (speedUpTime > 10 && balloonStart == EnemyBalloonStart.NoStart)
        {
            balloonStart = EnemyBalloonStart.Start;
        }
        if (speedUpTime > 20 && birdStart == EnemyBirdStart.NoStart)
        {
            birdStart = EnemyBirdStart.Start;
        }
        if (speedUpTime > 150 && planeStart == EnemyPlaneStart.NoStart)
        {
            planeStart = EnemyPlaneStart.Start;
        }
        if (speedUpTime > 440 && spaceshipStart == EnemySpaceshipStart.NoStart)
        {
            spaceshipStart = EnemySpaceshipStart.Start;
        }




        if (balloonStart == EnemyBalloonStart.Start)
        {
            StartCoroutine(StartBalloons());
            balloonStart = EnemyBalloonStart.Started;

        }
        if (birdStart == EnemyBirdStart.Start)
        {
            StartCoroutine(StartBirds());
            birdStart = EnemyBirdStart.Started;

        }
        if (planeStart == EnemyPlaneStart.Start)
        {
            StartCoroutine(StartPlanes());
            planeStart = EnemyPlaneStart.Started;

        }
        if (spaceshipStart == EnemySpaceshipStart.Start)
        {
            StartCoroutine(StartSpaceships());
            spaceshipStart = EnemySpaceshipStart.Started;

        }
    }



    IEnumerator StartBalloons()
    {
        Debug.Log("coroutine started");
        while (true)
        {
            Instantiate(balloon);


            yield return new WaitForSeconds(5f);


            Debug.Log("coroutine ended");

        }

    }


    IEnumerator StartBirds()
    {
        Debug.Log("coroutine started");
        while (true)
        {
            Instantiate(bird);


            yield return new WaitForSeconds(3f);

            Debug.Log("coroutine ended");

        }

    }

    IEnumerator StartPlanes()
    {
        Debug.Log("coroutine started");
        while (true)
        {
            Instantiate(plane);


            yield return new WaitForSeconds(2f);

            Debug.Log("coroutine ended");

        }

    }

    IEnumerator StartSpaceships()
    {
        Debug.Log("coroutine started");
        while (true)
        {
            Instantiate(spaceship);


            yield return new WaitForSeconds(1f);

            Debug.Log("coroutine ended");

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(player.GetComponent<Collider2D>() == gameObject.GetComponent<Collider2D>())
        lifeController.RemoveLife();

    }


}
