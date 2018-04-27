using UnityEngine;
using System.Collections;	
using UnityEngine.SceneManagement;

public class TouchMovement: MonoBehaviour {


	public Transform GameElements;
	private float ScreenWidth;

	void start() {


		GameElements = GetComponent<Transform>();
	}

	void Update()
	{

		float diff = Mathf.Floor(GameElements.position.x) - Mathf.Floor(transform.position.x);


		if (Input.GetTouch (4).position.x > ScreenWidth / 2 )
		{
			transform.position += new Vector3(-4, 0, 0);
		}
		if (Input.GetTouch (-4).position.x < ScreenWidth / 2)
		{
			transform.position += new Vector3(4, 0, 0);
		}

 

	}
}
	