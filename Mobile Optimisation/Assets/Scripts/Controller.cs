using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private float velocity = 20f;
    private float angularVelocity = 200f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.parent.Translate(Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime * velocity);
        transform.parent.Translate(Input.GetAxis("Vertical") * Vector3.forward * Time.deltaTime * velocity);

        if (Input.GetMouseButton(0))
        {
            transform.parent.Rotate(Vector3.up, Input.GetAxis("Mouse X") *  Time.deltaTime * angularVelocity);
            transform.Rotate(Vector3.left, Input.GetAxis("Mouse Y") * Time.deltaTime * angularVelocity);
        }
        
    }
}
