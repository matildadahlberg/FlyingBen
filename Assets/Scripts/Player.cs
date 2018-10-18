using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Player : MonoBehaviour
{

    public BackgroundScroller backgroundScroller;
    public LifeController lifeController;
    public MeterController meterController;
    public MainMenu mainMenu;


    [SerializeField] float speed = 10F;
    [SerializeField] float padding = 1F;
    [SerializeField] float offset = 2.0f;
    float xMin;
    float xMax;
    float yMin;
    float yMax;

    public int direction = 1;
    public float verticalSpeed;
    public Vector3 tempPosition;

    public int soundEffectsOn;

    private bool movable = false;

    private void Start()
    {
        
    }

    void Update()
    {
        Move();
        //MoveWithKeys();
        SetUpMoveBounderies();

    }

    void Move()
    {

        if (Input.touchCount > 0) {

            if (Input.GetTouch(0).phase == TouchPhase.Began) {
                // if touch on player
                Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

                RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

                if( hit.collider != null && hit.collider.tag == "Touch") {
                    
                    movable = true;
                }

                    

            }



            if (Input.GetTouch(0).phase == TouchPhase.Moved  && movable){


                Touch touch = Input.GetTouch(0);

                Vector2 pos = Camera.main.ScreenToWorldPoint(touch.position);
                pos.y += offset;

                transform.position = (Vector3)pos;
            }

            if (Input.GetTouch(0).phase == TouchPhase.Ended) {
                movable = false;
            }

        }

    }
    void SetUpMoveBounderies()
    {

        Camera gameCamera = Camera.main;
        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;
        yMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        yMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "LifeTag")
        {

            lifeController.AddLife();

            Destroy(collision.gameObject);

            if (soundEffectsOn != PlayerPrefs.GetInt("soundEffects",0))
            {
                FindObjectOfType<AudioManager>().Play("Life");
            }

            
           

        }
        else if (collision.gameObject.tag == "ArrowUp")
        {

            StartCoroutine(StartArrowUpSpeed());


            Destroy(collision.gameObject);

        }

        else if (collision.gameObject.tag == "ArrowDown")
        {

            StartCoroutine(StartArrowDownSpeed());

            Destroy(collision.gameObject);


        }

        else {

            lifeController.RemoveLife();

            Destroy(collision.gameObject);

            if (soundEffectsOn != PlayerPrefs.GetInt("soundEffects", 0)){

                FindObjectOfType<AudioManager>().Play("Crash");
            }

        }

    }




    void MoveWithKeys()
    {

        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var newX = transform.position.x + deltaX;

        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        var newY = transform.position.y + deltaY;

        transform.position = new Vector2(newX, newY);
    }

    IEnumerator StartArrowUpSpeed()
    {
        backgroundScroller.SpeedUp();
        meterController.speedUp *= 2;



            yield return new WaitForSeconds(5.0f);

        backgroundScroller.SpeedNeutral();
        meterController.speedUp /= 2;
    }

    IEnumerator StartArrowDownSpeed()
    {
        backgroundScroller.SpeedDown();
        meterController.speedUp -= 4;

            yield return new WaitForSeconds(5.0f);

        backgroundScroller.SpeedNeutral();
        meterController.speedUp += 4;

    }
}
