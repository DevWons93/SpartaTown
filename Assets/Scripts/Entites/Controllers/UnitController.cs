using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // �÷��̾� Move�� ���� ���� �̺�Ʈ
    public event Action<Vector2> OnLookEvent;
    public event Action<bool> OnDashEvent;
   
    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); // ? ������ ���� ������ ����
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    public void CallDashEvent(bool isPressed)
    {
        OnDashEvent?.Invoke(isPressed);
    }
}
