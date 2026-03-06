using UnityEngine;

public class SlideMovement : MonoBehaviour
{
    public float speed = 1f;
    public float magnitude = 1f;
    public Vector3 direction = Vector3.right;
    
    // Update is called once per frame
    void Update()
    {
        // Time.time -> how much time passed
        // since we started the game
        float distance = Mathf.Sin(Time.time * speed);
        
        // Move the object based on its parent
        transform.localPosition = direction * distance * magnitude;
    }
}
