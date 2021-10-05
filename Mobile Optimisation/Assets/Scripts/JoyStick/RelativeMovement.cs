using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelativeMovement : MonoBehaviour
{
    public float strafeSpeed, forwardSpeed, naturalSpeed;

    public Vector2 inputDirection;

    public void SetDirectionInput(Vector2 moveValue)
    {
        inputDirection = moveValue;
    }

    public Vector3 CalculateDirection()
    {
        Vector3 forwardDirection = transform.forward * inputDirection.y * forwardSpeed;
        Vector3 strafeDirection = transform.right * inputDirection.x * strafeSpeed;
        Vector3 naturalDirection = transform.forward * naturalSpeed;

        return forwardDirection + strafeDirection + naturalDirection;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += CalculateDirection() * Time.deltaTime;
    }
}
