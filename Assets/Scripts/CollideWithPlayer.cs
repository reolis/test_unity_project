using UnityEngine;

public class CollideWithPlayer : MonoBehaviour
{
    public GameObject obstacle;
    Rigidbody2D obstacleRb;
    Collider2D obstacleColl;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obstacleRb = obstacle.GetComponent<Rigidbody2D>();
        obstacleColl = obstacle.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
