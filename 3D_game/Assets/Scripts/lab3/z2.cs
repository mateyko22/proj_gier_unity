using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class z2 : MonoBehaviour
{
    public float speed = 10.0f;
    Rigidbody rb;
    private Vector3 initialPosition;
    private bool movingRight = true;

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
            }
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x < initialPosition.x)
            {
                movingRight = true;
            }
        }
    }
}
