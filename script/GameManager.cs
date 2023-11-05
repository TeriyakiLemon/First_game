
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public player player;
    public Text ScoreText;
    public GameObject playButton;

    public GameObject gameOver;

    public GameObject QuitButton;
    // Start is called before the first frame update
    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play()
    {
        score = 0;
        ScoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        QuitButton.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        pipes[] pipes = FindObjectsOfType<pipes>();

        for(int i = 0;i < pipes.Length; i++){
            Destroy(pipes[i].gameObject);
        }


    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        QuitButton.SetActive(true);
        Pause();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void IncreaseScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }
}
