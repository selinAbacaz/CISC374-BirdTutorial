using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerScore;
    public AudioSource scoreSound;

    public Text scoreText;
    public Text bestText;
    public int bestScore;
    public bool gameIsOver= true;

    public GameObject gameOverScreen;
    public GameObject titleScreen;


    public void Start()
    {
        titleScreen.SetActive(true);
        Time.timeScale= 0;
        bestText.text= "Best: " + PlayerPrefs.GetInt(HighScoreKey, 0);
        
    }

    private const string HighScoreKey = "HighScore";
    public void SaveHighScore(int score)
    {
        int currentHighScore = PlayerPrefs.GetInt(HighScoreKey, 0);
        


        if (score > currentHighScore)
        {
            PlayerPrefs.SetInt(HighScoreKey, score); 
            PlayerPrefs.Save();
            Debug.Log("New High Score Saved: " + score);
        }
        bestScore= currentHighScore;
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt(HighScoreKey, 0); // Get stored high score or default to 0
    }



    public void addScore(int scoreToAdd){
        if(!gameIsOver){
            scoreSound.Play();
            playerScore= playerScore+ scoreToAdd;
            scoreText.text= playerScore.ToString();
            

        }
        SaveHighScore(playerScore);
        

    }

    public void restartGame(){
        gameIsOver= false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void gameOver(){
        gameIsOver= true;
        gameOverScreen.SetActive(true);
    }

    public void startGame(){
        gameIsOver= false;
        titleScreen.SetActive(false);
        Time.timeScale=1;
    }
}
