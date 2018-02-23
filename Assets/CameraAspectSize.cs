using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraAspectSize : MonoBehaviour {

    private Camera Camera;
   

	// Use this for initialization
	void Start () {
        Camera = GetComponent<Camera>();
        float aspect = Camera.main.aspect;

        float AspectRounded = (float)Math.Round((double)aspect, 2);


        //5:4
        if (AspectRounded == 1.25f)
        {
            Camera.main.orthographicSize = 8;
        }

        //16:9
        if (AspectRounded == 1.78f)
        {
            Camera.main.orthographicSize = 5.5f;

        }      

        //3:2
        if (AspectRounded == 1.5f)
        {
            Camera.main.orthographicSize = 6.6f;


        }

        //4:3
        if (AspectRounded == 1.33)
        {
            Camera.main.orthographicSize = 7.6f;


        }
        //Debug.Log(AspectRounded);
    }

}



