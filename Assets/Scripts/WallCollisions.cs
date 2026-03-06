using UnityEngine;

public class WallCollisions : MonoBehaviour
{
    public Growth growth;

    private void OnCollisionEnter(Collision other)
    {
        // To reverse a boolean, add a ! in front
        // !true = false
        // in this case, this means "if growth cannot shrink"
        if (!growth.CanShrink())
        {
            Destroy(gameObject);
            return; // Stops the code here
        }
        
        growth.Shrink();
    }
}
