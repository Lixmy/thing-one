using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class ManagementScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public TMP_Text scoreText;
    public int counter;
    public FloorScript floor;
    public ObstacleScript obstacle;
    public float initMoveSpeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    void Update()
    {
        foreach(FloorScript floor in FindObjectsOfType<FloorScript>()){
                floor.moveSpeed = initMoveSpeed;
        }
        foreach(ObstacleScript obstacle in FindObjectsOfType<ObstacleScript>()){
                obstacle.moveSpeed = initMoveSpeed;
        }
    }

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
        speedUp();
    }

    [ContextMenu("Speed Up")]
    public void speedUp()
    {
        if(counter % 3 == 0)
        {
            foreach(FloorScript f in FindObjectsOfType<FloorScript>()){
                initMoveSpeed += 0.5f;
            }
            foreach(ObstacleScript o in FindObjectsOfType<ObstacleScript>()){
                initMoveSpeed += 0.5f;
            }
        }
    }
}
