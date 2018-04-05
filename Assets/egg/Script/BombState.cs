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
        if (col.gameObject.tag == "Ground")
        {
            transform.eulerAngles = Vector3.zero;


            Destroy(this.gameObject, 0.6f);
        }

        if (col.gameObject.tag == "Basket")
        {

            StartCoroutine("Bomb");
            Destroy(this.gameObject);
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.2f);
            GetComponent<AudioSource>().Play();


        }
    }




    // Update is called once per frame
    void Update()
    {
        Space();

    }
}
