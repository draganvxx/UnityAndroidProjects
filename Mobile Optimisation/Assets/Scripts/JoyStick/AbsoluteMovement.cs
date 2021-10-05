using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsoluteMovement : MonoBehaviour
{
    public float speed = 1;

    public Vector3 currentDirection;

    public void MoveDirectionXY(Vector2 moveValue)
    {
        currentDirection = moveValue;
    }

    public void MoveDirectionXZ(Vector2 moveValue)
    {
        currentDirection = new Vector3(moveValue.x, 0, moveValue.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += currentDirection * speed * Time.deltaTime;
    }
}
