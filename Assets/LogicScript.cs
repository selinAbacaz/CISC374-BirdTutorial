using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerScore;
    public AudioSource jumpSound;

    public Text scoreText;
    public bool gameIsOver= false;

    public GameObject gameOverScreen;

    [ContextMenu("increase score")]
    public void addScore(int scoreToAdd){
        if(!gameIsOver){
            jumpSound.Play();
            playerScore= playerScore+ scoreToAdd;
            scoreText.text= playerScore.ToString();

        }
        

    }

    public void restartGame(){
        gameIsOver= false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void gameOver(){
        gameIsOver= true;
        gameOverScreen.SetActive(true);
    }
}
