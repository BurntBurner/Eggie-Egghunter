using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollision : MonoBehaviour {

    public Rigidbody[] rbArray = new Rigidbody[] {};
    public eggFlight eggflight;
    public Animator[] EggArray = new Animator[] {};
    // Use this for initialization
    void Start()
    {
        // direction = (target.position - transform.position).normalized;
        //orthogonal = new Vector3 (-direction.z, 0, direction.x);
        

    }

    void OnCollisionEnter (Collision other) {
        if (other.gameObject.tag == "egg")
        {
            foreach (Animator EggAni in EggArray)
            {
                EggAni.SetTrigger("CrushOnEarth");
            }
            Debug.LogWarning("TriggerEnter");
            Debug.Log(GetComponent<Collider>().gameObject.name);
            Debug.Log(other.gameObject.name);

            foreach(Rigidbody rb in rbArray)
            {
               
                rb.AddForce(Vector3.zero);
            }
            
        }

	}


}

