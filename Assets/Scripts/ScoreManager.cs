using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour

{
    public static ScoreManager instance;
    public int score;
    public int highScore;
    public Text scoreDisplay;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        PlayerPrefs.SetInt("score", score);
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = score.ToString();
    }
    public void IncrementScore()
    {
        score += 1;
       

    }
    public void StartScore()
    {
        InvokeRepeating(nameof(IncrementScore), 1f, 0.5f);
        
    }
     public void StopScore()
    {
        CancelInvoke(nameof(IncrementScore));
        PlayerPrefs.SetInt("score", score);
        if (PlayerPrefs.HasKey("highScore"))
        {
            if (score > PlayerPrefs.GetInt("highScore"))
            {
                PlayerPrefs.SetInt("highScore", score);
            }


        } 
        else
        {
            PlayerPrefs.SetInt("highScore", score);
        }
    }
}
