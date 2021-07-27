using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabsOpener : MonoBehaviour
{
    public GameObject tabs;

    public void OpenTabs()
    {
        if (tabs != null)
        {
            bool isActive = tabs.activeSelf;
            tabs.SetActive(!isActive);
        }
    }
}
