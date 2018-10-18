using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour
{

    public float horizontalSpeed;

    Vector3 tempPosition;

    public int direction = 1;

    private void Start()
    {
        tempPosition = transform.localPosition;
    }

    private void Update()
    {
        tempPosition.x = tempPosition.x + (direction * horizontalSpeed);
       
        transform.localPosition = tempPosition;
            
    }

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blocker")
        {
            Destroy(gameObject);
        }

    }


}

