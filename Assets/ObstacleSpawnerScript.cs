using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
    public GameObject Obstacle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(Obstacle, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SpawnObstacle()
    {
        Instantiate(Obstacle, transform.position, transform.rotation);
    }
}
