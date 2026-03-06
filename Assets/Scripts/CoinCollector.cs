using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public Growth growth;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with " + other.name);
        
        growth.Grow();
        Destroy(other.gameObject);
    }
}
