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

    private float startTime;
    //private Vector3 direction;
    //private Vector3 orthogonal;



    // Use this for initialization
    void Start() {
        
        startTime = Time.time;
        // direction = (target.position - transform.position).normalized;
        //orthogonal = new Vector3 (-direction.z, 0, direction.x);
        Invoke("ThrowEgg", startafter);

        // init Rb array from Prefabs
      /*  for (int i = 0; i < EggPrefabs.Length; i++)
        {
            rbForces[i] = EggPrefabs[i].GetComponent<Rigidbody>();
            Debug.Log(EggPrefabs);

        }
        */
    }




    // Update is called once per frame
    void Update()
    {
       

    }

    void ThrowEgg()
	{


        float randomTime = Random.Range(randomRangeMin, randomRangeMax);
 
        //generate IndexNumbers
        int indexGO = Random.Range(0 , 2);
        int indexForce = Random.Range(0, 2);
        //Debug.Log(indexGO);

        //Instantiate Go and call index
        Eggprefab = Instantiate(EggPrefabs[indexGO], transform.position, transform.rotation);
        Eggprefab.GetComponent<Rigidbody>().AddForce(ForceVector[indexForce]);
       

        // if state Collision pass
       
        
   
        //float t = Time.time - startTime;
		//rb.velocity = direction * speed + orthogonal * amplitude * Mathf.Sin (frequency * t);
		//rb.AddForce(new Vector3(forceX,forceY,0));
		//rb.velocity = Vector3.zero;
		//rb.angularVelocity = Vector3.zero;
		//rb.useGravity = true;

		Invoke ("ThrowEgg", randomTime);

	}
    


}

