using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public Growth growth;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Debug.Log("Collided with " + other.name);
        
            growth.Grow();
            Destroy(other.gameObject);
        }
    }
}
