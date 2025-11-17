using UnityEngine;

public class BottomWallController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            FindObjectOfType<GameManager>().GameOver();
            Destroy(collision.gameObject);
        }
    }
}
