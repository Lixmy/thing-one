using UnityEngine;

public class FloorDetectorScript : MonoBehaviour
{
    public FloorSpawnerScript floorSpawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Floor"))
        {
            floorSpawner.SpawnFloor();
        }
    }
}
