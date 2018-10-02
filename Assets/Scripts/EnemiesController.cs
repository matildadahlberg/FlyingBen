using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour
{
    public Player playerScript;


    public float horizontalSpeed;
    public float verticalSpeed;
    public float amplitude;

    public Vector3 tempPosition;

    private void Start()
    {
        //StartCoroutine("myCoRotouine");

        tempPosition = transform.position;
    }

    private void Update()
    {

        tempPosition.x += horizontalSpeed;
        //tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude;
        transform.position = tempPosition;



    }

    private void OnCollisionEnter2D(Collision2D collision)
    { 
        Destroy(gameObject);

    }




}

