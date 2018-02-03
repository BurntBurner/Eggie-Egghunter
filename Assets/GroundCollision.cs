using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollision : MonoBehaviour {

    public EggState[] EggPrefabs;
    public EggState EggPrefab;
    public Animator EggAni;
    public Collider col;
    // Use this for initialization
    void Start()
    {
     
     
         
        // direction = (target.position - transform.position).normalized;
        //orthogonal = new Vector3 (-direction.z, 0, direction.x);

        EggAni = GetComponent<Animator>();

    }

    void OnCollisionEnter (Collision other) {
        if (other.gameObject.tag == "egg")
        {
            for(int i = 0; i < EggPrefabs.Length; i++)
            {
               EggAni = EggPrefabs[i].GetComponentInChildren<Animator>(); 
               EggAni.SetTrigger("CrushOnEarth");
            }

                
            }
            Debug.LogWarning("TriggerEnter");
            Debug.Log(GetComponent<Collider>().gameObject.name);
            Debug.Log(other.gameObject.name);

            /*foreach(Rigidbody rb in rbArray)
            {
               
               // rb.AddForce(Vector3.zero);
            }
            */
        }

	}




