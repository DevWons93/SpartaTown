using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;

public class UnitMovement : MonoBehaviour
{
    [SerializeField][Range(0f, 20f)] private float speed = 5f;

    private UnitController controller;
    private Rigidbody2D rigidbody;

    private Vector2 movementDirection = Vector2.zero;
    private float boost = 1f;

    private void Awake()
    {   
        controller = GetComponent<UnitController>();
        rigidbody = GetComponent<Rigidbody2D>();        
    }
        
    private void Start()
    {
        controller.OnMoveEvent += Move;
        controller.OnDashEvent += Dash;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * speed * boost;

        rigidbody.velocity = direction;
    }

    private void Dash(bool isPressed)
    {
        if (movementDirection == Vector2.zero) return; // 이동이 없으면 대쉬 X
        boost = isPressed ? 2f : 1f;
    }
}
