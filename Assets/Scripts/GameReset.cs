using UnityEngine;

public class GameReset : MonoBehaviour
{
    public Transform player;
    public Vector2 resetPosition = new Vector2(0, 0);
    public float resetThreshold = -5f;

    void Update()
    {
        if (player.position.y < resetThreshold)
        {
            ResetGame();
        }
    }

    void ResetGame()
    {
        CoinSpawner.coinCount = 0;
        player.position = resetPosition;
        Debug.Log("Игра началась заново. Монеты сброшены.");
    }
}
