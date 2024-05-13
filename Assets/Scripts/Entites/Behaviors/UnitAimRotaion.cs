using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using UnityEngine;

public class UnitAimRotaion : MonoBehaviour
{
    [SerializeField] private SpriteRenderer unitRenderer;

    private UnitController controller;

    private void Awake()
    {
        controller = GetComponent<UnitController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; 

        unitRenderer.flipX = Mathf.Abs(rotZ) > 90f; 
    }

}
