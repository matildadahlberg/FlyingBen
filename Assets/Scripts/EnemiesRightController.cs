using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesRightController : MonoBehaviour {
    
    public float horizontalSpeed;
    public float verticalSpeed;
    public float amplitude;

    public Vector3 tempPosition;

    private void Start()
    {
        tempPosition = transform.position;
    }

    private void Update()
    {
        tempPosition.x -= horizontalSpeed;
        //tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude;
        transform.position = tempPosition;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Blocker")
        {
            Destroy(gameObject);

            Debug.Log("Krock");

        }

    }

}
