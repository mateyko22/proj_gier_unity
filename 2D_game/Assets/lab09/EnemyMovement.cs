using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rgdBody;
    public Transform pointA;
    public Transform pointB;
    private float dirX;

    void Start()
    {
        rgdBody = GetComponent<Rigidbody2D>();
        dirX = 1;
    }

    void Update()
    {
        rgdBody.velocity = new Vector2(dirX * moveSpeed, rgdBody.velocity.y);
        if (dirX > 0 && transform.position.x >= pointB.position.x)
        {
            changeDirection();
        }
        else if (dirX < 0 && transform.position.x <= pointA.position.x)
        {
            changeDirection();
        }
    }


    void changeDirection()
    {
        dirX *= -1;
        Vector2 heroScale = gameObject.transform.localScale;
        heroScale.x *= -1;
        gameObject.transform.localScale = heroScale;
    }
}
