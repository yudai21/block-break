using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearUI : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false); // 最初は非表示
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void OnRestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
