using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    [SerializeField]
    public GameObject prefab;

    public GameObject Prefab { set { prefab = value; } }

    public void InstantiatePrefab()
    {
        Instantiate(prefab, transform);
    }

    public void ChangePrefab(GameObject newPrefab)
    {
        Instantiate(newPrefab, transform);
    }
}
