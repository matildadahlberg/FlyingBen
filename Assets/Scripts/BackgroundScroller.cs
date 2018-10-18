using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{

    public Vector3 tempPosition;
    public float speed = 0.004f;
    //Material myMaterial;
    //Vector2 offSet;

    // Use this for initialization
    void Start()
    {
        //myMaterial = GetComponent<Renderer>().material;
        //offSet = new Vector2(0f, speed);
        tempPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //myMaterial.mainTextureOffset += offSet * Time.deltaTime;
        tempPosition.y = tempPosition.y - (speed);
        transform.localPosition = tempPosition;
    }

    public void SpeedUp() {
        speed = 0.04f;
        tempPosition = transform.position;
        tempPosition.y = tempPosition.y - (speed);
        transform.localPosition = tempPosition;
        //offSet = new Vector2(0f, speed);
        //myMaterial.mainTextureOffset += offSet * Time.deltaTime;
        
    }

    public void SpeedNeutral()
    {
        speed = 0.004f;
        //offSet = new Vector2(0f, speed);
        //myMaterial.mainTextureOffset += offSet * Time.deltaTime;

    }

    public void SpeedDown()
    {
        speed = -0.04f;
        //offSet = new Vector2(0f, speed);
        //myMaterial.mainTextureOffset += offSet * Time.deltaTime;

    }

}
