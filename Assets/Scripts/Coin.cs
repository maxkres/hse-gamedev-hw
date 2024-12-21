using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CoinSpawner.coinCount++;
            Destroy(gameObject);
            FindAnyObjectByType<CoinSpawner>().OnCoinCollected();
            Debug.Log("Coins Collected: " + CoinSpawner.coinCount);
        }
    }
}