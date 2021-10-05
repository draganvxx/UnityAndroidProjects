using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public float maximumDistance;
    public Transform joystickHandle;

    [System.Serializable]
    public class Vector2UnityEvent : UnityEvent<Vector2> {}
    public Vector2UnityEvent joystickOutput;

    public Vector3 CalculatePosition(Vector3 userInput)
    {
        if(Vector3.SqrMagnitude(transform.position - userInput) > maximumDistance * maximumDistance)
        {
            userInput = transform.position + (userInput - transform.position).normalized * maximumDistance;
        }

        return userInput;
    }

    public void OnDrag(PointerEventData eventData)
    {
        joystickHandle.position = CalculatePosition(eventData.position);

        Vector2 inputRatio = joystickHandle.localPosition / maximumDistance;

        joystickOutput?.Invoke(inputRatio);
        //Debug.Log(inputRatio);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        joystickHandle.localPosition = new Vector3();
        joystickOutput?.Invoke(new Vector2());
    }
}
