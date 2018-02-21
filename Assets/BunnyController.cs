using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BunnyController : MonoBehaviour {

	public Text ScoredEggs;
	private int score;
    
	void start()
	{
		score = 0;
	}

	void Update()
	{

		float diff = Mathf.Floor(Camera.main.transform.position.x) - Mathf.Floor(transform.position.x);


		if (Input.GetKeyDown(KeyCode.LeftArrow) && diff < 4.1f)
		{
			transform.position += new Vector3 (-4,0,0); 
		}
		if (Input.GetKeyDown(KeyCode.RightArrow) && diff > -4.0f)
		{
			transform.position += new Vector3(4,0,0);
		}



	}

    private void OnCollisionEnter(Collision collision)
    {
        
		if (collision.gameObject.tag == "egg") {

			score += 1;
			ScoredEggs.text = "EGGS: " + score.ToString ();
		}

		Debug.Log ("score: " + score);
	}
}
