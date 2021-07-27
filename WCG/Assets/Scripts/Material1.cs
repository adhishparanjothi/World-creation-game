using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material1 : MonoBehaviour, IInventoryItem
{
    public string Name
    {
        get
        {
            return " Material1";
        }
    }
    public Sprite _Image = null;

    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }

    public void OnPickup()
    {
        //TODO : Add logic what happens when material is picked up 
        gameObject.SetActive(false);
    }


    private float boundary = 24;
    private Vector3 mOffset;
    private float mZCoord;
    public void OnDrop()
    {


        //TODO : move a logic to a base class or helper methos

        RaycastHit hit = new RaycastHit();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit,1000))
        {
            gameObject.SetActive(true);
            gameObject.transform.position = hit.point;
        }
    }
}
