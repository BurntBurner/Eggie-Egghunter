using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggState : MonoBehaviour {

    private Animator animator;
    private Rigidbody rB;
    public int Value;
    

    // Use this for initialization
    void Start () {

        animator = GetComponentInChildren<Animator>();
        rB = GetComponent<Rigidbody>();
        
       


    }
	void Space()
    {
        if(transform.position.y < -10)
        {
            Destroy(this.gameObject);
        }
        

    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Ground")
        {
            transform.eulerAngles = Vector3.zero;
            animator.SetTrigger("CrushOnEarth");
            rB.isKinematic = true;
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.2f);
            GetComponent<AudioSource>().Play();
            Destroy(this.gameObject, 0.6f);
        }

        if(col.gameObject.tag == "Basket")
        {

            Destroy(this.gameObject);
           
        }
    }

    


	// Update is called once per frame
	void Update () {
        Space();
        
    }
}
