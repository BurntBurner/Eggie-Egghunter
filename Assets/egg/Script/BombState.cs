using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombState : MonoBehaviour
{

    private Rigidbody rB;
    public int damage;
    public Text text;
    public GameObject BombParticle;
    public AudioSource Explosion;
    private float rangeSFX;

    // Use this for initialization
    void Start()
    {


        rB = GetComponent<Rigidbody>();



    }



    void Space()
    {
        if (transform.position.y < -10)
        {
            Destroy(this.gameObject);
        }


    }

    public IEnumerator Bomb()
    {

        BombParticle.SetActive(true);

        GameObject BombClone = Instantiate(BombParticle, transform.position, Quaternion.identity);

        BombParticle.SetActive(false);

        Destroy(BombClone, 1);

        yield return null;

    }

    void OnCollisionEnter(Collision col)
    {

        rangeSFX = Random.Range(0.8f, 1.2f);
        GetComponent<AudioSource>().pitch = rangeSFX;
        GetComponent<AudioSource>().volume = 0.2f;
        GetComponent<AudioSource>().Play();

        if (col.gameObject.tag == "Ground")
        {
            transform.eulerAngles = Vector3.zero;



        }

        if (col.gameObject.tag == "Basket")
        {
            /*rangeSFX = Random.Range(0.8f, 1.2f);
			GetComponent<AudioSource> ().pitch = rangeSFX;
			GetComponent<AudioSource> ().volume = 0.2;
			GetComponent<AudioSource>().Play();*/
            StartCoroutine("Bomb");
        }
        Destroy(this.gameObject, rangeSFX);
    }




    // Update is called once per frame
    void Update()
    {
        Space();

    }
}
