using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private GameObject focalPoint;
    public float speed = 5.0f;
    private float boundary = 24;
    public Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        

        playerRb.AddForce(focalPoint.transform.forward * verticalInput * speed);
        playerRb.AddForce(focalPoint.transform.right * horizontalInput * speed);
        if(transform.position.x > boundary)
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

    private void OnCollisionEnter(Collision collision)
    {
        IInventoryItem item = collision.collider.GetComponent<IInventoryItem>();
        if (item != null)
        {
            inventory.AddItem(item);
        }
    }
}
