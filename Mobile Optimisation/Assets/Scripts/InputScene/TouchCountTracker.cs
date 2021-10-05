using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TouchCountTracker : MonoBehaviour
{
    [System.Serializable]
    public class StringUnityEvent : UnityEvent<string> { }
    public StringUnityEvent updateText;

    // Update is called once per frame
    void Update()
    {
        updateText?.Invoke("Finger count: " + Input.touchCount.ToString());
    }
}
