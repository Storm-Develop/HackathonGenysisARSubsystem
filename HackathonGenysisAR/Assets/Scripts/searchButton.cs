using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class searchButton : MonoBehaviour
{
    public GameObject arcamera;
    public InputField Field;
    public Text TextBox;

    public void CopyText()
    {
        TextBox.text = Field.text;
        Debug.Log(TextBox.text.ToString());
    }

    public void test()
    {
        Debug.Log("works");
    }

}

