using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 10;
    private Vector3 objNormalVector = Vector3.zero;
    private Rigidbody rb;
    private Vector3 afterReflectVelocity = Vector3.zero;
    void Start()
    { 
        rb = GetComponent<Rigidbody>();  
        var force = (transform.forward + transform.right) * speed;
        rb.velocity = force;
        afterReflectVelocity = rb.velocity;    
    }
    

    public void OnCollisionEnter(Collision collision)
    {
        objNormalVector = collision.contacts[0].normal;
        Vector3 reflectVec = 
        Vector3.Reflect(afterReflectVelocity,objNormalVector);
        rb.velocity = reflectVec;

        afterReflectVelocity = rb.velocity;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
