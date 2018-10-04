﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesLeftController : MonoBehaviour
{
    
    public float horizontalSpeed;
    public float verticalSpeed;
    public float amplitude;

    public Vector3 tempPosition;

    public int direction = 1;

    private void Start()
    {
        //StartCoroutine("myCoRotouine");

        tempPosition = transform.position;

    }

    private void Update()
    {

        tempPosition.x = tempPosition.x + (direction * horizontalSpeed);
        //tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude;
        transform.position = tempPosition;



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blocker")
        {

            Debug.LogError("Krock left");

            Destroy(gameObject);



        }

    }


    private void OnDestroy()
    {
        Debug.LogError("destroyed:" + gameObject.name);
    }






}

