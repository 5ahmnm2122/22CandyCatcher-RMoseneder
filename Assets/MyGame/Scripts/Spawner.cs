using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] candy;
    public GameObject[] badCandy;
    

    //  public bool waitedOnce = false;

    public float xBounds, yBound;


    void Start()
    {
        StartCoroutine(SpawnCandies());
        StartCoroutine(SpawnCandies_2());
    }

    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomCandy = Random.Range(0, candy.Length);
        int randomBadCandy = Random.Range(0, badCandy.Length);

        if (Random.value <= 0.5f)
        {
            Instantiate(candy[randomCandy],
                new Vector3(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);

            yield return new WaitForSeconds(Random.Range(0.05F, 0.25F));

            Instantiate(badCandy[randomBadCandy],
                 new Vector3(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);



            //  yield return new WaitForSeconds(1);

            // Instantiate(candy[randomCandy],
            //   new Vector3(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);

        }

        else
        {
            Instantiate(badCandy[randomBadCandy],
                 new Vector3(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);

            yield return new WaitForSeconds(Random.Range(0.05F, 0.25F)); 

            Instantiate(candy[randomCandy],
                new Vector3(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);

            // yield return new WaitForSeconds(1);

            //  Instantiate(badCandy,
            //   new Vector3(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        }

        StartCoroutine(SpawnCandies());
       
    }

    IEnumerator SpawnCandies_2()
    {

        // 
        // if(waitedOnce = false)
        //  {
        //   
        //   waitedOnce = true;
        // }
        //
        yield return new WaitForSeconds(10);
        yield return new WaitForSeconds(Random.Range(0.05F, 0.25F));

        int randomCandy = Random.Range(0, candy.Length);
        int randomBadCandy = Random.Range(0, badCandy.Length);

        if (Random.value <= 0.5f)
        {
            Instantiate(candy[randomCandy],
                new Vector3(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);

            yield return new WaitForSeconds(Random.Range(0.5F, 1F));




            //  yield return new WaitForSeconds(1);

            // Instantiate(candy[randomCandy],
            //   new Vector3(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);

        }

        else
        {
            Instantiate(badCandy[randomBadCandy],
                new Vector3(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity) ;

            yield return new WaitForSeconds(Random.Range(0.5F, 1F));



            // yield return new WaitForSeconds(1);

            //  Instantiate(badCandy,
            //   new Vector3(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        }

        StartCoroutine(SpawnCandies());

    }

}
