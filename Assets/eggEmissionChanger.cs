using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggEmissionChanger : MonoBehaviour {

    public Material material;
    private MeshRenderer rend;
    private float change = 0;

    // Use this for initialization
    void Start () {
        material = GetComponent<MeshRenderer>().material;
        material.SetFloat("_EmissionColor", change);
    }
	
	// Update is called once per frame
	void Update () {


        if (change == 0)
        {
            change = 1;

        }
        else
        {
            if (change == 1)
            {
                change = 0;


            }

           




        }
        Color EmissionCol = new Color(change, change, change);

        material.SetColor("_EmissionColor", EmissionCol);
    }
}
