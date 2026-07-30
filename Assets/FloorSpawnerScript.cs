using UnityEngine;

public class FloorSpawnerScript : MonoBehaviour
{
    public GameObject Floor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(Floor, new Vector3(3.81f, -2.99f, 0f), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SpawnFloor()
    {
        Instantiate(Floor, transform.position, transform.rotation);
    }
}
