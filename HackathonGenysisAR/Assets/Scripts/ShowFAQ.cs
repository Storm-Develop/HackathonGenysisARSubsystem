using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFAQ : MonoBehaviour
{
    public Button FAQ1;
    public Button FAQ2;
    public Button FAQ3;
    public Button FAQ4;
    public Button FAQ5;

    // Start is called before the first frame update
    void Start()
    {
        FAQ1.interactable = true;
        FAQ2.interactable = true;
        FAQ3.interactable = true;
        FAQ4.interactable = true;
        FAQ5.interactable = true;
    }
    public void test()
    {
        Debug.Log("works");
    }

}
