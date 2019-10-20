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
        FAQ1.interactable = false;
        FAQ2.interactable = false;
        FAQ3.interactable = false;
        FAQ4.interactable = false;
        FAQ5.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void test()
    {
        Debug.Log("works");
    }

}
