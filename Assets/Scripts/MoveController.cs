using System;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }
}
