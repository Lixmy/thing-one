using UnityEngine;

public class InitialFloorSpawnScript : MonoBehaviour
{
    public GameObject Floor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnFloor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnFloor()
    {
        Instantiate(Floor, transform.position, transform.rotation);
    }
}
