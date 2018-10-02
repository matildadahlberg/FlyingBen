using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public EnemiesController enemies;
  

    [SerializeField] float speed = 10F;
    [SerializeField] float padding = 1F;
    [SerializeField] float offset = 1.5f;
    float xMin;
    float xMax;
    float yMin;
    float yMax;

    public GameObject player;

    private void Start()
    {
        //Instantiate(player);

        SetUpMoveBounderies();
    }


    void Update () {

        //Move();
        MoveWithKeys();
	}

    void SetUpMoveBounderies() {
        
        Camera gameCamera = Camera.main;
        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;
        yMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        yMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;
    }

    void Move() {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            // Get movement of the finger since last frame
            //Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            // Move object across XY plane
            //transform.Translate(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);


            Touch touch = Input.GetTouch(0);

            Vector2 pos = Camera.main.ScreenToWorldPoint(touch.position);
            pos.y += offset;

            transform.position = (Vector3)pos;

        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Krock");

    }

    void MoveWithKeys()
    {

        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var newX = transform.position.x + deltaX;
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        var newY = transform.position.y + deltaY;

        transform.position = new Vector2(newX, newY);
    }
}
