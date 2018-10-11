using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour
{

    public float horizontalSpeed;
    public float verticalSpeed;
    public float amplitude;

    public Vector3 tempPosition;

    public int direction = 1;

    private void Start()
    {
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
            Destroy(gameObject);
        }

    }


}

