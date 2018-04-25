using UnityEngine;
using System.Collections;	
using UnityEngine.SceneManagement;

public class bt_left: MonoBehaviour {

	public void Left()
	{

		transform.position += new Vector3(-4, 0, 0);

	}
}
