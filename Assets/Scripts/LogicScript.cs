using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public float playerScores = 0;
    public Text scoreText;
    public Text scoreGameOver;
    public GameObject crosshair;
    public GameObject menuScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        crosshair.SetActive(false);
        menuScreen.SetActive(true);
        Time.timeScale = 0;
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
        crosshair.SetActive(false);
    }

    public void addScore(int scoreToAdd)
    {
        playerScores = playerScores + scoreToAdd;
        scoreText.text = playerScores.ToString();
        scoreGameOver.text = "Score: " + playerScores.ToString();
    }
    public void startGame()
    {
        Time.timeScale = 1;
        menuScreen.SetActive(false); 
        crosshair.SetActive(true);
    }
    public static void Quit()
    {
        Application.Quit();
    }

}
