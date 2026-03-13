using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float speed = 10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidbody.AddForce(transform.up * speed, ForceMode.Impulse);
        Destroy(gameObject, 3f);
    }
}
