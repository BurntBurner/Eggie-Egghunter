using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombFlightTestGblur : MonoBehaviour {

    //public Animator CrushedEgg;

    public int cannonBullets;
    public int ForceindexRange; 
	public float startafter;
	public float randomRangeMin;
	public float randomRangeMax;
    public BombState[] BombPrefabs;
    public BombState Bombprefab;
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
        int indexGO = Random.Range(0 , cannonBullets);
        int indexForce = Random.Range(0, ForceindexRange);
        int indexTorque = Random.Range(0, ForceindexRange);
        //Debug.Log(indexGO);

        //Instantiate Go and call index
        Bombprefab = Instantiate(BombPrefabs[indexGO], transform.position, transform.rotation);
        Bombprefab.GetComponent<Rigidbody>().AddForce(ForceVector[indexForce]);
        Bombprefab.GetComponent<Rigidbody>().AddTorque(TorqueVector[indexTorque]);

        Invoke("ThrowEgg", randomTime);

        // play throwing sfx

        GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.2f);
        GetComponent<AudioSource>().Play();


        //float t = Time.time - startTime;
        //rb.velocity = direction * speed + orthogonal * amplitude * Mathf.Sin (frequency * t);
        //rb.AddForce(new Vector3(forceX,forceY,0));
        //rb.velocity = Vector3.zero;
        //rb.angularVelocity = Vector3.zero;
        //rb.useGravity = true;



    }
    


}

