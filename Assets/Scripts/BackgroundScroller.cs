using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{

    public float speed = 0.004f;
    Material myMaterial;
    Vector2 offSet;

    // Use this for initialization
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
        offSet = new Vector2(0f, speed);
    }

    // Update is called once per frame
    void Update()
    {
        myMaterial.mainTextureOffset += offSet * Time.deltaTime;

    }

    public void SpeedUp() {
        speed = 0.04f;
        offSet = new Vector2(0f, speed);
        myMaterial.mainTextureOffset += offSet * Time.deltaTime;
        
    }

    public void SpeedNeutral()
    {
        speed = 0.004f;
        offSet = new Vector2(0f, speed);
        myMaterial.mainTextureOffset += offSet * Time.deltaTime;

    }

    public void SpeedDown()
    {
        speed = -0.04f;
        offSet = new Vector2(0f, speed);
        myMaterial.mainTextureOffset += offSet * Time.deltaTime;

    }

}
