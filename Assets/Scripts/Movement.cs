using UnityEngine;

public class Movement : MonoBehaviour
{
    // Public -> Accessor
    // String -> Data type
    public string playerName = "Ben Dover";
    public int lives = 3;
    public float movementSpeed = 5.5f;
    public bool isAlive = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("My name is " + playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
