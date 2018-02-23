using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour {

	private float speed;

	void Start()
	{
		speed = 10;
	}

	void Update()
	{
		//if(Input.GetKey(KeyCode.D))
		//{
			transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
		//}
		//if(Input.GetKey(KeyCode.A))
		//{
		//	transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
		//}
	}
}
