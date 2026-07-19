using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LogicScrip : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    
    public enum GameState { Start, Playing, Over }
    public GameState currentState = GameState.Start;

    public GameObject gameStartPanel;
    public GameObject gamePlayingPanel;
    public GameObject gameOverPanel;

    public Rigidbody2D birdRigidbody;
    public LogSpawnerScrip logSpawner;

    private void Start()
    {
        currentState = GameState.Start;
        gameStartPanel.SetActive(true);
        gameOverPanel.SetActive(false);
        birdRigidbody.bodyType = RigidbodyType2D.Kinematic;
        logSpawner.enabled = false;
    }

    public void AddScore()
    {
        playerScore ++;
        scoreText.text = playerScore.ToString();
    }
     
    public void StartGame()
    {
        Debug.Log("Play Button Clicked");

        currentState = GameState.Playing;
        gameStartPanel.SetActive(false);
        gamePlayingPanel.SetActive(true);
        birdRigidbody.bodyType = RigidbodyType2D.Dynamic;
        logSpawner.enabled = true;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        currentState = GameState.Over;
        gameOverPanel.SetActive(true);
        logSpawner.enabled = false;
    }
}
