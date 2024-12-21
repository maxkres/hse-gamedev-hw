using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public Vector2 spawnAreaMin = new Vector2(-10, -1);
    public Vector2 spawnAreaMax = new Vector2(10, 1);
    public static int coinCount = 0;
    private int maxCoins = 10;

    void Start()
    {
        for (int i = 0; i < maxCoins; i++)
        {
            SpawnCoin();
        }
    }

    public void SpawnCoin()
    {
        float x = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
        float y = Random.Range(spawnAreaMin.y, spawnAreaMax.y);
        Vector2 spawnPosition = new Vector2(x, y);
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }

    public void OnCoinCollected()
    {
        SpawnCoin();
    }
}
