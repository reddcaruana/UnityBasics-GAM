using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    // Public -> Accessor
    // String -> Data type
    public string playerName = "Ben Dover";
    public int lives = 3;
    
    public float movementSpeed = 5.5f;
    public float rotationSpeed = 180f;
    
    public bool isAlive = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("My name is " + playerName);
    }

    // Update is called once per frame
    void Update()
    {
        // A basic condition to check
        // for the W key
        if (Keyboard.current.wKey.isPressed)
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }

        if (Keyboard.current.sKey.isPressed)
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        }

        if (Keyboard.current.aKey.isPressed)
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
        
        if (Keyboard.current.dKey.isPressed)
        {
            transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
        }
        
        // Accesses the Transform component
        // transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
    }
}
