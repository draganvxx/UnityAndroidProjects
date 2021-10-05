using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Raycaster : MonoBehaviour
{
    [Header("Properties")]
    public Camera mainCamera;
    public LayerMask layers;
    public float raycastDistance = 10;

    [System.Serializable]
    public class StringUnityEvent : UnityEvent<string> { }
    [System.Serializable]
    public class Vector3UnityEvent : UnityEvent<Vector3> { }

    [Header("Events"), Space]
    public StringUnityEvent hitTargetName;
    public Vector3UnityEvent hitPosition;
    public Vector3UnityEvent hitNormal;


    // Start is called before the first frame update
    void Start()
    {
        if (!mainCamera)
        {
            mainCamera = Camera.main;
        }    
    }

    public void DrawRay(Vector3 position)
    {
        Ray ray = mainCamera.ScreenPointToRay(position);

        Debug.DrawRay(ray.origin, ray.direction);
    }

    public void Raycast(Vector3 position)
    {
        RaycastHit hit;
        Ray ray = mainCamera.ScreenPointToRay(position);
        bool hasHit = Physics.Raycast(ray, out hit, raycastDistance, layers);

        if (hasHit)
        {
            hitTargetName?.Invoke(hit.transform.name);
            hitPosition?.Invoke(hit.point);
            hitNormal?.Invoke(hit.normal);
        }
    }
}
