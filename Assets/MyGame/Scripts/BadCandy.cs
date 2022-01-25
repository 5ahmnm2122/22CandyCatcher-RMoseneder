using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCandy : MonoBehaviour
{

    public int scoreInt;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        { 
            Destroy(gameObject);
            GameManager.instance.IncrementScore(scoreInt);
        }

        if (collision.gameObject.tag == "Floor")
        {
            Destroy(gameObject);
        }

    }
}
