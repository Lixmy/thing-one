using UnityEngine;

public class ObstacleDetectorScript : MonoBehaviour
{
   public ObstacleSpawnerScript obstacleSpawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Obstacle"))
        {
            obstacleSpawner.SpawnObstacle();
        }
    }
}
