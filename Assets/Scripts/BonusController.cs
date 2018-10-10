using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusController : MonoBehaviour {

    public GameObject heart;
    public MeterController meterController;

    float randX;
    Vector2 whereToSpawn;
    float nextSpawn = 0.0f;


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


}
