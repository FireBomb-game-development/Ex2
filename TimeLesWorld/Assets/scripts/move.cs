using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    Rigidbody2D rb2d;

    public float moveSpeed;
    public float leftAngle;
    public float rightAngle;

    bool movingClockwise;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        movingClockwise = true;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void ChangeMoveDir()
    {
        float currentAngle = NormalizeAngle(transform.eulerAngles.z);

        if (currentAngle > rightAngle && currentAngle < 180f)
        {
            movingClockwise = false;
        }
        else if (currentAngle < leftAngle || currentAngle > 180f)
        {
            movingClockwise = true;
        }
    }

    public void Move()
    {
        ChangeMoveDir();

        if (movingClockwise)
        {
            rb2d.angularVelocity = moveSpeed;
        }
        else
        {
            rb2d.angularVelocity = -moveSpeed;
        }
    }

    // Normalize the angle to be in the range of -180 to 180 degrees
    private float NormalizeAngle(float angle)
    {
        angle %= 360;
        if (angle > 180)
        {
            angle -= 360;
        }
        return angle;
    }
}
