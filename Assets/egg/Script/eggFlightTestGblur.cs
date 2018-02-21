using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggFlightTestGblur : MonoBehaviour {

    //public Animator CrushedEgg;
    
        
	public float startafter;
	public float randomRangeMin;
	public float randomRangeMax;
    public EggState[] EggPrefabs;
    public EggState Eggprefab;
    public Vector2[] ForceVector = new Vector2[2];
    public Vector3[] TorqueVector = new Vector3[2];

    private float startTime;
    //private Vector3 direction;
    //private Vector3 orthogonal;



    // Use this for initialization
    void Start() {
        
        startTime = Time.time;
        // direction = (target.position - transform.position).normalized;
        //orthogonal = new Vector3 (-direction.z, 0, direction.x);
        Invoke("ThrowEgg", startafter);
    }

    void ThrowEgg()
	{


        float randomTime = Random.Range(randomRangeMin, randomRangeMax);
 
        //generate IndexNumbers
        int indexGO = Random.Range(0 , 5);
        int indexForce = Random.Range(0, 3);
        int indexTorque = Random.Range(0, 3);
        //Debug.Log(indexGO);

        //Instantiate Go and call index
        Eggprefab = Instantiate(EggPrefabs[indexGO], transform.position, transform.rotation);
        Eggprefab.GetComponent<Rigidbody>().AddForce(ForceVector[indexForce]);
        Eggprefab.GetComponent<Rigidbody>().AddTorque(TorqueVector[indexTorque]);

        Invoke("ThrowEgg", randomTime);
        


        //float t = Time.time - startTime;
        //rb.velocity = direction * speed + orthogonal * amplitude * Mathf.Sin (frequency * t);
        //rb.AddForce(new Vector3(forceX,forceY,0));
        //rb.velocity = Vector3.zero;
        //rb.angularVelocity = Vector3.zero;
        //rb.useGravity = true;



    }
    


}

