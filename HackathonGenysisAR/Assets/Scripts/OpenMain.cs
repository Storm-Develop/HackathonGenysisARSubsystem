using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMain : MonoBehaviour
{
    public GameObject menu;
    public GameObject ARcamera;

    public void exitAR()
    {
        menu.SetActive(true);
        ARcamera.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            exitAR();
        }
    }
}
