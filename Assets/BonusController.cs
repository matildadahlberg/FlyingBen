using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusController : MonoBehaviour {
    
    public float verticalSpeed;

    public Vector3 tempPosition;

    public int direction = -1;

    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    private void Start()
    {
        tempPosition = transform.position;
        StartCoroutine(StartHearts());
    }

    private void Update()
    {

        tempPosition.y = tempPosition.y + (direction * verticalSpeed);
        transform.position = tempPosition;

    }

   

    IEnumerator StartHearts()
    {
        Debug.Log("heartcoroutine started");
        while (true)
        {

            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                randX = Random.Range(-2f, 2.0f);
                whereToSpawn = new Vector2(randX, transform.position.y);
                Instantiate(gameObject, whereToSpawn, Quaternion.identity);
             
            }


            yield return new WaitForSeconds(10f);

            Debug.Log("heartcoroutine ended");

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blocker")
        {

            Debug.Log("Krock left");

            Destroy(gameObject);


        }

    }

}
