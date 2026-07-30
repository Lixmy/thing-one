using UnityEngine;

public class CatScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public ManagementScript manage;
    public bool isAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            rb.linearVelocity = Vector2.up * 10f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            manage.gameOver();
            isAlive = false;
        }
        
    }
}
