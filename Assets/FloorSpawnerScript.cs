using UnityEngine;

public class FloorSpawnerScript : MonoBehaviour
{
    public GameObject Floor;
    public float spawnRate = 3;
    private float timer = 0;
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
            SpawnFloor();
            timer = 0;
        }
    }
    
    void SpawnFloor()
    {
        Instantiate(Floor, transform.position, transform.rotation);
    }
}
