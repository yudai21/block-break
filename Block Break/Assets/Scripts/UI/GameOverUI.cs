using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false); // 最初は非表示
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    // Restartボタンに紐づける
    public void OnRestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
