using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject cactus1;
    public GameObject cactus2;

    Rigidbody2D rb1, rb2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb1 = cactus1.GetComponent<Rigidbody2D>();
        rb2 = cactus2.GetComponent<Rigidbody2D>();

        InvokeRepeating(nameof(Spawn1), 1f, 2.5f);
        InvokeRepeating(nameof(Spawn2), 1f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn1()
    {
        Vector3 pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), -2);
        GameObject cactus = Instantiate(cactus1, pos, Quaternion.identity);
        Destroy(cactus, 10f);
    }

    void Spawn2()
    {
        Vector3 pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), -2);
        GameObject cactus = Instantiate(cactus2, pos, Quaternion.identity);
        Destroy(cactus, 10f);
    }
}
