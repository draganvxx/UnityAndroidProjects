using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Script created for you to optimisse
/// </summary>
public class InRangeCheck : MonoBehaviour
{

    [Tooltip("The list of game object names to check if they are in range")]
    public List<string> targets;
    
    [Tooltip("The maximum allowed distance to be in range")]
    public float rangeDistance;

    [Tooltip("Is the object within range")]
    public bool allInRange;

    private void Awake()
    {
        
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        allInRange = true;
        foreach(string targetName in targets)
        { 
            GameObject target = GameObject.Find(targetName);
        

            if(target && !IsInRange(target.transform))
            { 
                allInRange = false;
            }
        }
    }

    public bool IsInRange(Transform target)
    {
        return Vector3.Distance(target.position, Camera.main.transform.position) < rangeDistance;
    }
}
