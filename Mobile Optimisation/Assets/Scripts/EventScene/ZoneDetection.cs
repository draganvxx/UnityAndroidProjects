using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Collider)), RequireComponent(typeof(Rigidbody))]
public class ZoneDetection : MonoBehaviour
{
    public ParticleSystem pSys;
    public Text collText;
    public List<GameObject> currentlyInTheZone = new List<GameObject>();

    [Serializable]
    public class StrUnityEvent : UnityEvent<string> { }
    public StrUnityEvent currentObjectCountInZone;
    public StrUnityEvent currentObjectNameInZone;
    public UnityEvent zoneEntered;
    public UnityEvent zoneExited;


    // Start is called before the first frame update
    void Start()
    {
        Collider col = GetComponent<Collider>();
        col.isTrigger = true;

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered the zone");
        zoneEntered?.Invoke();
        pSys.Play();
        currentlyInTheZone.Add(other.gameObject);
        currentObjectNameInZone?.Invoke(other.gameObject.name);
        currentObjectCountInZone?.Invoke(currentlyInTheZone.Count.ToString());
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Zone exited");
        zoneExited?.Invoke();
        pSys.Stop();
        currentlyInTheZone.Remove(other.gameObject);
        currentObjectNameInZone?.Invoke("none");
        currentObjectCountInZone?.Invoke(currentlyInTheZone.Count.ToString());
    }
}
