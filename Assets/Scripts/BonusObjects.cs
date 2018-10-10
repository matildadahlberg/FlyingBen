using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusObjects : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blocker")
        {

            Destroy(gameObject);


        }

    }
}
