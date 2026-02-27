using UnityEngine;

public class Coin : MonoBehaviour
{
    // How fast I will turn
    public float rotationSpeed = 180f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
