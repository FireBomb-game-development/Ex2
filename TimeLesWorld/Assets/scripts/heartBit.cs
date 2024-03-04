using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heartbeat : MonoBehaviour
{
    public float minScale ;
    public float maxScale ;
    public float scaleSpeed ;

    private Vector3 initialScale;

    // Start is called before the first frame update
    void Start()
    {
        initialScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        float scaleFactor = Mathf.PingPong(Time.time * scaleSpeed, 1f) * (maxScale - minScale) + minScale;

        // Scale the object from its center without changing its position
        transform.localScale = new Vector3(initialScale.x * scaleFactor, initialScale.y * scaleFactor, initialScale.z);
    }
}
