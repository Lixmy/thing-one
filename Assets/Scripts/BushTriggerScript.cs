using UnityEngine;

public class BushTriggerScript : MonoBehaviour
{
    public ManagementScript scoreManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<ManagementScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        scoreManager.addScore();
    }
}
