using UnityEngine;

public class Disappear : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Get the SpriteRenderer component
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer component not found on the object.");
        }
    }

    void Update()
    {
        // Check if the left mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            ToggleVisibility();
        }
    }

    private void ToggleVisibility()
    {
        // Toggle the visibility of the SpriteRenderer component
        if (spriteRenderer != null)
        {
            print(spriteRenderer.enabled);
            spriteRenderer.enabled = !spriteRenderer.enabled;
        }
        else
        {
            Debug.LogError("SpriteRenderer component not found.");
        }
    }
}
