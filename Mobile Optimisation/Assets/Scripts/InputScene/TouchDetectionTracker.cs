using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TouchDetectionTracker : MonoBehaviour
{
    // Track specific touch
    // Check every finger until one matches the tracked ID
    // Transform position follows touch position on screen

    public int trackedTouchID;
    public UnityEvent onBegan;
    public UnityEvent onMoved;
    public UnityEvent onStationary;
    public UnityEvent onEnded;
    public UnityEvent onCanceled;

    [System.Serializable]
    public class Vector3UnityEvent : UnityEvent<Vector3> { }
    public Vector3UnityEvent mouseScreenPosition;

    public TouchPhase currentTouchPhase;

    // Update is called once per frame
    void Update()
    {
        if(!EventSystem.current.IsPointerOverGameObject())
        mouseScreenPosition?.Invoke(Input.mousePosition);
        if (Input.GetMouseButtonDown(trackedTouchID))
            onBegan?.Invoke();
        if (Input.GetMouseButton(trackedTouchID))
            onMoved?.Invoke();
        if (Input.GetMouseButtonUp(trackedTouchID))
            onEnded?.Invoke();
        /*for (int i = 0; i < Input.touchCount; i++)
        {
            if(Input.GetTouch(i).fingerId == trackedTouchID)
            {
                Touch touch = Input.GetTouch(i);
                fingerScreenPosition?.Invoke(touch.position);

                if(currentTouchPhase != touch.phase)
                {
                    ProcessPhase(touch.phase);
                }
            }
        }*/
    }

    /*public void ProcessPhase(TouchPhase phase)
    {
        switch (phase)
        {
            case TouchPhase.Began:
                onBegan?.Invoke();
                break;
            case TouchPhase.Moved:
                onMoved?.Invoke();
                break;
            case TouchPhase.Stationary:
                onStationary?.Invoke();
                break;
            case TouchPhase.Ended:
                onEnded?.Invoke();
                break;
            case TouchPhase.Canceled:
                onCanceled?.Invoke();
                break;
        }
    }

    public void SetColourWithHexa(string hexacolour)
    {

    }*/
}
