using UnityEngine;

public class Growth : MonoBehaviour
{
    // Variables
    // Min / Max Growth
    public float minSize = 0.2f;
    public float maxSize = 3f;

    // Growth Rate
    public float growthRate = 0.2f;

    // Current Size
    private float currentSize = 1f;

    // Makes the rocket longer
    public void Grow()
    {
        currentSize += growthRate;
        if (currentSize > maxSize)
        {
            currentSize = maxSize;
        }

        // Change the model size
        transform.localScale = Vector3.one * currentSize;
    }

    // Makes the rocket shorter
    public void Shrink()
    {
        currentSize -= growthRate;
        if (currentSize < minSize)
        {
            currentSize = minSize;
        }

        // Change the model size
        transform.localScale = Vector3.one * currentSize;
    }

    public bool CanShrink()
    {
        return currentSize > minSize;
    }
}