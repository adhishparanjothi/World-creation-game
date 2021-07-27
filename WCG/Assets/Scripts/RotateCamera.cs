using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    private float rotationSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseScroll = Input.GetAxis("Mouse ScrollWheel");
        transform.Rotate(Vector3.up * rotationSpeed * mouseScroll);
        
    }
}
