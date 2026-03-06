using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnPoint;
    public Growth growth;
    
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && growth.CanShrink())
        {
            Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
            growth.Shrink();
        }
    }
}
