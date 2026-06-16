using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject coin;
    public GameObject[] coins;
    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating(nameof(Spawn), 3f, 3.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        Vector3 pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), -2);
        GameObject t_coin = Instantiate(coins[Random.Range(0, coins.Length)], pos, Quaternion.identity);

        Destroy(t_coin, 5f);
    }
}
