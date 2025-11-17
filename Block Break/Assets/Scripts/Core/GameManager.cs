using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isGameOver = false;
    [SerializeField] private GameOverUI gameOverUI;
    [SerializeField] private GameClearUI gameClearUI;

    public void GameOver()
    {
        if (isGameOver) return;
        isGameOver = true;

        Debug.Log("Game Over!");
        StopAllBalls();
        if (gameOverUI != null)
            gameOverUI.Show();
    }

    public void CheckClear()
    {
        if (isGameOver) return;
        StartCoroutine(CheckClearNextFrame());
    }

    private IEnumerator CheckClearNextFrame()
    {
        yield return null; // 次のフレームまで待機

        int remainingBlocks = GameObject.FindGameObjectsWithTag("Block").Length;
        Debug.Log("Remaining Blocks: " + remainingBlocks);

        if (remainingBlocks == 0)
        {
            Debug.Log("Game Clear!");
            StopAllBalls();
            if (gameClearUI != null)
                gameClearUI.Show();
            else
                Debug.LogWarning("GameClearUI is null!");
            isGameOver = true;
        }
    }


    private void StopAllBalls()
    {
        // シーン内の全てのボールを停止
        var balls = GameObject.FindGameObjectsWithTag("Ball");
        foreach (var ball in balls)
        {
            var rb = ball.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }
}
