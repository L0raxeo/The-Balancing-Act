using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementBehavior : MonoBehaviour
{

    private void Update()
    {
        MovePlatform();
    }

    public Rigidbody2D rb;

    private void MovePlatform()
    {
        float speed = Input.acceleration.x;
        //transform.position = new Vector3(transform.position.x + speed / 3, -5f, 0f);

        rb.velocity = new Vector2(speed * 50f, 0f);

        if (transform.position.x < -9.5f)
            transform.position = new Vector3(-9.5f, -5f, 0f);
        else if (transform.position.x > 9.5f)
            transform.position = new Vector3(9.5f, -5f, 0f);
    }

}
