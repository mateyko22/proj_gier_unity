using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class z3 : MonoBehaviour
{
    public float speed = 10.0f;
    Rigidbody rb;
    private Vector3 initialPosition;
    private Quaternion Rotation;
    private bool movingRight = true;
    private bool movingLeft = false;
    private bool movingForward = false;
    private bool movingBack = false;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.x > initialPosition.x + 10)
            {   
                movingRight = false;
                movingForward = true;
                transform.Rotate(0, 270, 0, Space.Self);
            }
        }
        else if (movingForward)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.z > initialPosition.z + 10)
            {
                movingForward = false;
                movingLeft = true;
                transform.Rotate(0, 270, 0, Space.Self);
            }
        }
        else if (movingLeft)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.x <= 0)
            {
                movingLeft = false;
                movingBack = true;
                transform.Rotate(0, 270, 0, Space.Self);
            }
        }
        else if (movingBack)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.z <= initialPosition.z)
            {
                movingBack = false;
                movingRight = true;
                transform.Rotate(0, 270, 0, Space.Self);
            }
        }
    }
}
