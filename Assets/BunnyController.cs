using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BunnyController : MonoBehaviour
{

    public Transform GameElements;
    public Text ScoredEggs;
    private int score;
    private int damage;
    

    void start()
    {
        
        score = 0;
        GameElements = GetComponent<Transform>();
    }

    void Update()
    {

        float diff = Mathf.Floor(GameElements.position.x) - Mathf.Floor(transform.position.x);


        if (Input.GetKeyDown(KeyCode.LeftArrow) && diff < 4.1f)
        {
            transform.position += new Vector3(-4, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && diff > -4.0f)
        {
            transform.position += new Vector3(4, 0, 0);
        }



    }
    
       

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "egg")
        {
            
            score += 1;
            ScoredEggs.text = score.ToString();
        }

        

        }

    }

