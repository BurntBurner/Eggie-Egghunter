using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {

    Vector2 uvOffset = Vector2.zero;
    //public string textureName = "_MainTex";
    public float uvSpeedY;
    public float uvSpeedX;
    public Material Mat;

    private void Start()
    {
        Mat = GetComponent<SpriteRenderer>().material;
        
    }

    void LateUpdate()
    {

        Vector2 uvAnimSpeed = new Vector2(uvSpeedX, uvSpeedY);

        uvOffset += (uvAnimSpeed * Time.deltaTime);
        //if( GetComponent<Renderer>().enabled )
        //{
        Mat.SetTextureOffset("_MainTex", uvOffset);
        //}

    }
}

