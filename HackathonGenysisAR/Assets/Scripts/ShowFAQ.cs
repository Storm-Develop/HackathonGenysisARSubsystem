using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFAQ : MonoBehaviour
{
    public GameObject FAQ1;
    public GameObject FAQ2;
    public GameObject FAQ3;
    public GameObject FAQ4;
    public GameObject FAQ5;

    // Start is called before the first frame update
    void Start()
    {
        FAQ1.SetActive(false);
        FAQ2.SetActive(false);
        FAQ3.SetActive(false);
        FAQ4.SetActive(false);
        FAQ5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void show()
    {
        FAQ1.GetComponentInChildren<Text>().text = "1";
        FAQ2.GetComponentInChildren<Text>().text = "2";
        FAQ3.GetComponentInChildren<Text>().text = "3";
        FAQ4.GetComponentInChildren<Text>().text = "4";
        FAQ5.GetComponentInChildren<Text>().text = "5";

        FAQ1.SetActive(true);
        FAQ2.SetActive(true);
        FAQ3.SetActive(true);
        FAQ4.SetActive(true);
        FAQ5.SetActive(true);
    }

}
