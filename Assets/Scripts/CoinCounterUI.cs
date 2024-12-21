using UnityEngine;
using UnityEngine.UI;

public class CoinCounterUI : MonoBehaviour
{
    public Text coinCounterText;

    void Start()
    {
        UpdateCoinCounter();
    }

    void Update()
    {
        UpdateCoinCounter();
    }

    void UpdateCoinCounter()
    {
        coinCounterText.text = "Шекелей собрано: " + CoinSpawner.coinCount;
    }
}