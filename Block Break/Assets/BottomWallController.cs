using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomWallController : MonoBehaviour
{
    private void OnCollisionEnter (Collision collision)
    {
        Destroy (collision.gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
