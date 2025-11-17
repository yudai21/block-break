using UnityEngine;

public class BlockController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        FindObjectOfType<GameManager>().CheckClear();
        Debug.Log("CheckClear called");
    }
}
