using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody rigidBody;
    public bool isRunning = true;
    Vector3 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.LeftShift) && isRunning == false)
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }
    }
    void FixedUpdate()
    {
        if (isRunning)
        {
            rigidBody.MovePosition(rigidBody.position + (movement * (moveSpeed * 1.5f) * Time.fixedDeltaTime));
        }
        else
        {
            rigidBody.MovePosition(rigidBody.position + (movement * moveSpeed * Time.fixedDeltaTime));
        }

    }
}
