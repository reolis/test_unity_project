using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject player;
    Rigidbody2D rb; // Физическая основа нашего игрока
    float speed = 4f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>(); // Получение физической составляющей нашего игрока
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
