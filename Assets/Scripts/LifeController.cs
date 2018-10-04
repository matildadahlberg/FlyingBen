using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeController : MonoBehaviour {

    public GameObject gameIsRunning;
    public GameObject gameOverPage;
    

    [SerializeField]
    private int lives = 3;
    public float distance = 0.7f;

    private void Start()
    {

        gameOverPage.SetActive(false);

        for (int i = 1; i < lives; i++)
        {
            GameObject newLife = Instantiate(transform.GetChild(0).gameObject);
            newLife.transform.SetParent(transform);
            Vector3 pos = newLife.transform.position;
            pos.x += (i * distance);
            newLife.transform.position = pos;

        }
    }


    public void RemoveLife()
    {

        lives--;
        transform.GetChild(lives).gameObject.SetActive(false);

        if (lives == 0) {
            gameIsRunning.SetActive(false);
            gameOverPage.SetActive(true);
            
        }
            
            
            

    }

}
