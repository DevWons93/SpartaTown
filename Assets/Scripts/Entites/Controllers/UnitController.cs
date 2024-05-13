using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // 플레이어 Move에 따라 생길 이벤트
    public event Action<Vector2> OnLookEvent;
    public event Action<bool> OnDashEvent;
   
    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); // ? 없으면 말고 있으면 실행
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
