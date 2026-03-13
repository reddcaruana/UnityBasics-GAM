using TMPro;
using UnityEngine;

public class Growth : MonoBehaviour
{
    // Variables
    public TMP_Text girthText;
    
    // Min / Max Growth
    public float minSize = 0.2f;
    public float maxSize = 3f;

    // Growth Rate
    public float growthRate = 0.2f;

    // Current Size
    private float currentSize = 1f;

    private void Start()
    {
        UpdateText();
    }

    // Makes the rocket longer
    public void Grow()
    {
        currentSize += growthRate;
        if (currentSize > maxSize)
        {
            currentSize = maxSize;
        }
        
        UpdateText();

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
        
        UpdateText();

        // Change the model size
        transform.localScale = Vector3.one * currentSize;
    }

    public bool CanShrink()
    {
        // + 0.01f is to make sure currentSize
        // meets this condition
        return currentSize > minSize + 0.01f;
    }

    public void UpdateText()
    {
        float percent = currentSize / maxSize;
        girthText.text = $"Girth: {percent:P}";
    }
}