using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    public GameObject zigzagPanel;
    public GameObject gameOverPanel;
    public GameObject tapText;
    public Text score;
    public Text highScore;
    public Text bestScore;

    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        highScore.text = "High Score: " + PlayerPrefs.GetInt("highScore");
    }
    private void Update()
    {
        if (GameManager.instance.gameOver == true)
        {

        }
    }

    public void GameStart()
    {
        tapText.SetActive(false);
        zigzagPanel.GetComponent<Animator>().Play("MoveUp");
    }
    public  void GameOver()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
        bestScore.text = PlayerPrefs.GetInt("highScore").ToString(); 
        gameOverPanel.SetActive(true);

    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
