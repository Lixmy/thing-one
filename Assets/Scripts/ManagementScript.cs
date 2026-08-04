using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class ManagementScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public FloorScript Floor;
    public ObstacleScript Obstacle;
    public TMP_Text scoreText;
    public int counter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        counter++;
        scoreText.text = "Score : " + counter.ToString();
    }
}
