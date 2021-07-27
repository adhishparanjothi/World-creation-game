using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building2 : MonoBehaviour, IInventoryItem
{
    public string Name
    {
        get
        {
            return " Building2";
        }
    }
    public Sprite _Image;
    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }

    public void OnDrop()
    {
        RaycastHit hit = new RaycastHit();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 1000))
        {
            gameObject.SetActive(true);
            gameObject.transform.position = hit.point;
        }
    }

    public void OnPickup()
    {
        gameObject.SetActive(false);
    }

}
