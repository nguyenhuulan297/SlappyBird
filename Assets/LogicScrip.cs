using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScrip : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    public void AddScore()
    {
        playerScore ++;
        scoreText.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
