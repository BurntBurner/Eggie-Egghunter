using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggFlight : MonoBehaviour {
	private Rigidbody rb;
	//public Animator CrushedEgg;


	public float startafter;
	public float randomRangeMin;
	public float randomRangeMax;
	public float forceX;
	public float forceY;
	// public Transform target;
	//public float speed;
	//public float amplitude;
	//public float frequency;

	private float startTime;
	//private Vector3 direction;
	//private Vector3 orthogonal;



	// Use this for initialization
	void Start () {
		startTime = Time.time;
		// direction = (target.position - transform.position).normalized;
		//orthogonal = new Vector3 (-direction.z, 0, direction.x);
		rb = GetComponent<Rigidbody> ();
		Invoke ("ThrowEgg", startafter);



	}

	// Update is called once per frame
	void Update () {
		
		/*if (Input.GetKeyDown (KeyCode.Space)) {
			CrushedEgg.SetTrigger ("CrushOnEarth");
		}*/
	}

	void ThrowEgg()
	{
		float randomTime = Random.Range (randomRangeMin, randomRangeMax);
		
		Vector3 pos = Camera.main.transform.position;
		pos.x += 10f;
		pos.y += 1.5f;
		pos.z += 7f;
		this.transform.position = pos;

		float t = Time.time - startTime;
		//rb.velocity = direction * speed + orthogonal * amplitude * Mathf.Sin (frequency * t);
		rb.AddForce(new Vector3(forceX,forceY,0));
		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;
		rb.useGravity = true;

		Invoke ("ThrowEgg", randomTime);

	}
	/// <summary>
	/// Raises the collision enter event. If egg crushes earth, ly down.
	/// </summary>
	/// <param name="other">Other.</param>
	void OnCollisionEnter (Collision other) {

		Debug.LogWarning ("TriggerEnter");
		Debug.Log (GetComponent<Collider>().gameObject.name);
		Debug.Log (other.gameObject.name);
		rb.useGravity = false;
	

	}


}

