using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{

    public int scoreInt;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameManager.instance.IncrementScore(scoreInt);
            Destroy(gameObject);

          
        }

        if (collision.gameObject.tag == "Floor")
        {
            
            Destroy(gameObject);


        }
    }
}
