using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Finish the level
            GameManager manager = FindAnyObjectByType<GameManager>();
            manager.Finish();
        }
    }
}
