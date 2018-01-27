using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EggCrush : MonoBehaviour {
	public Text CrushedEggs;
	private Animator CrushedEgg;
    public GameObject Eggs;
	private int score;
	// Use this for initialization
	void Start () {
		score = 0;
		CrushedEgg = GetComponent<Animator>();

        //Instantiate(Eggs, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("FUCK");
		if (other.gameObject.tag == "Basket") {
			//CrushedEgg.SetTrigger("CrushOnEarth");
			score += 1;
			CrushedEggs.text = "CRUSHEDEGGS: " + score.ToString ();
            //Destroy(gameObject,.5f);
            


		}
	}


}
