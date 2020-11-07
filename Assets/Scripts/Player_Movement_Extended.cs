using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement_Extended : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D rigBody;
    Vector2 _movement;

    void Update()
    {
        _movement.x = Input.GetAxis("Horizontal");
        _movement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        rigBody.MovePosition(rigBody.position + _movement * movementSpeed * Time.deltaTime);
    }
}
