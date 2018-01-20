using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroundHit : MonoBehaviour {
	
	public Text CrushedEggs;
	private int score;

	void start()
	{
		score = 0;
	}

	void Update()
	{


	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "egg") {

			score += 1;
			CrushedEggs.text = "CRUSHEDEGGS: " + score.ToString ();


			eggFlight scrambledEgg = other.GetComponent<eggFlight> ();
			/*if (scrambledEgg != null) { 

				if (scrambledEgg.CrushedEgg != null) {
					scrambledEgg.smashEgg ();
			
				}
			}*/
		}

		Debug.Log ("Crushed " + score);
	}
}
