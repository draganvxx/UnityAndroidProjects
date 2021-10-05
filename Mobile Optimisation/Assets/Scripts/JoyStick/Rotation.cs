using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public float pitchAngularSpeed, rollAngularSpeed, yawAngularSpeed;

    private float dX, dY, dZ;

    public void DeltaAngle(Vector2 moveValues)
    {
        dX = moveValues.x;
        dY = moveValues.y;
    }

    public void DeltaYaw(Vector2 moveValue)
    {
        dZ = moveValue.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(dY * pitchAngularSpeed * Time.deltaTime, dZ * yawAngularSpeed * Time.deltaTime, -dX * rollAngularSpeed * Time.deltaTime);
    }
}
