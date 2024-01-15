using UnityEngine;

// Transform.rotation example.

// Rotate a GameObject using a Quaternion.
// Tilt the cube using the arrow keys. When the arrow keys are released
// the cube will be rotated back to the center using Slerp.

public class ExampleScript : MonoBehaviour
{
    float smooth = 5.0f;
    public float minScale;
    public float maxScale;
    public float scaleSpeed;
    public bool tiltY;
    public bool tiltX;
    float tiltAroundX;
    float tiltAroundY;

    void Update()
    {
        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ =  Mathf.Lerp(minScale, maxScale, 0.5f + 0.5f * Mathf.Sin(Time.time * scaleSpeed));
        if (tiltX)  tiltAroundX = Mathf.Lerp(minScale, maxScale, 0.5f + 0.5f * Mathf.Sin(Time.time * scaleSpeed));

        if(tiltY) tiltAroundY = Mathf.Lerp(minScale, maxScale, 0.5f + 0.5f * Mathf.Sin(Time.time * scaleSpeed));
        // Rotate the cube by converting the angles into a quaternion.
        
        Quaternion target = Quaternion.Euler(tiltAroundX, tiltAroundY, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}