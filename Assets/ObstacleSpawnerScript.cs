using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
    public GameObject Obstacle;

    public float spawnRate = 5;
    public float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnObstacle();
            timer = 0;
        }
    }

    void SpawnObstacle()
    {
        Instantiate(Obstacle, transform.position, transform.rotation);
    }
}
