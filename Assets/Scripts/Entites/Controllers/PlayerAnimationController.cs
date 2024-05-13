using System;
using UnityEngine;

public class PlayerAnimationController : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("IsWalking");
    private static readonly int isDash = Animator.StringToHash("IsDash");

    private readonly float magnituteThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
        controller.OnDashEvent += Dash;
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalking, vector.magnitude > magnituteThreshold);
    }

    private void Dash(bool isPressed)
    {
        animator.SetBool(isDash, isPressed);
    }
}