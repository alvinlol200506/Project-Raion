using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public int playerScores = 0;
    public Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void addScore(int scoreToAdd)
    {
        playerScores = playerScores + scoreToAdd;
        scoreText.text = playerScores.ToString();
    }
    public void reduceScore(int scoreToReduce)
    {
        playerScores = playerScores - scoreToReduce;
        scoreText.text = playerScores.ToString();
    }
}
