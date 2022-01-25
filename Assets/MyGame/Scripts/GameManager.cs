using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public InputField inputField;
    public Text scoreText;
    public Text lifesholder;
    public int lives = 3;
    bool gameOver = false;
 
    public void TakeName()
    {
        PlayerPrefs.SetString("user_name", inputField.text);
        Debug.Log("Your Name is" + PlayerPrefs.GetString(" user_name"));
      
    }

    private void Awake()
    {
        instance = this;
    }


    public void SaveScore()
    {

        PlayerPrefs.SetInt("amountOfBeans", score);
    }

    public void IncrementScore(int differentScores)
    {
        if(gameOver == false)
        {
            score+= differentScores;
            scoreText.text = score.ToString();
            
        }

    }
    
}

