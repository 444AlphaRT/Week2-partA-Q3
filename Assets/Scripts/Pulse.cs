using UnityEngine;

public class Pulse : MonoBehaviour
{
    public float speed = 2f;        // How fast the pulsing happens
    public float scaleAmount = 0.2f; // How much the object grows/shrinks

    private Vector3 originalScale;   // Store the original size of the object

    void Start()
    {
        // Save the starting scale of the object when the game begins
        originalScale = transform.localScale;
    }

    void Update()
    {
        // Create a smooth pulsing value using a sine wave
        // Mathf.Sin returns values between -1 and +1
        float s = 1f + Mathf.Sin(Time.time * speed) * scaleAmount;

        // Apply the pulsing scale to the object
        transform.localScale = originalScale * s;
    }
}
