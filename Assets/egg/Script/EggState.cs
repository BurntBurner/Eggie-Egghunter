﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggState : MonoBehaviour {

    private Animator animator;
    private Vector3 transformEgg;
    private MeshRenderer Render;
	// Use this for initialization
	void Start () {

        animator = GetComponentInChildren<Animator>();
        
	}
	
    void Space()
    {
        
        if (this.transform.position.y <= -10)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Ground")
        {
            animator.SetTrigger("CrushOnEarth");
            
            Destroy(this.gameObject, 0.6f);
        }
    }

    


	// Update is called once per frame
	void Update () {
        Space();
        
	}
}
