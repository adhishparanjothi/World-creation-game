using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DragDrop : MonoBehaviour
{
    private float boundary = 24;
    private Vector3 mOffset;
    private float mZCoord;
    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(
            gameObject.transform.position).z;
        // Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;
        // z coordinate of game object on screen
        mousePoint.z = mZCoord;
        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = new Vector3(GetMouseAsWorldPoint().x + mOffset.x, transform.position.y, GetMouseAsWorldPoint().z + mOffset.z);
    }
    private void Update()
    {
        if (transform.position.x > boundary)
        {
            transform.position = new Vector3(boundary, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -boundary)
        {
            transform.position = new Vector3(-boundary, transform.position.y, transform.position.z);
        }
        if (transform.position.z > boundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, boundary);
        }
        if (transform.position.z < -boundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -boundary);
        }
    }

}
