using UnityEngine;
using UnityEngine.SceneManagement;
public class ManagementScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public FloorScript Floor;
    public ObstacleScript Obstacle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
