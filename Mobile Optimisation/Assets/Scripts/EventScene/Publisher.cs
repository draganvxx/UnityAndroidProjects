using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Publisher : MonoBehaviour
{
    [Serializable]
    public class IntUnityEvent : UnityEvent<int> { }
    //public delegate void SeeSharpEvent(int edition);
    public IntUnityEvent PublishedNewContent;

    private int editionNumber;

    public void NotifySubscriber()
    {

        PublishedNewContent?.Invoke(editionNumber);
        editionNumber++;
        //PublishedNewContent?.Invoke();
    }

}
