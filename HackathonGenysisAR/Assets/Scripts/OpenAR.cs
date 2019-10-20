using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAR : MonoBehaviour
{

    public GameObject menu; 
    public GameObject ARcamera;

    public void SwitchToAR()
    {
        menu.SetActive(false);
        ARcamera.SetActive(true);
        
    }
}
