using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMovement : MonoBehaviour
{
    public float speed = 100;
    private Vector3 currentDirection;

    public void MoveDirection(Vector2 moveValue)
    {
        currentDirection = moveValue;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += currentDirection * speed * Time.deltaTime;
    }
}
