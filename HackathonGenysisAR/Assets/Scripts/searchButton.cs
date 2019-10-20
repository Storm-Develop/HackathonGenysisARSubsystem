using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SearchButton : MonoBehaviour
{
    public GameObject ARscene;
    public InputField SearchTextInputFeld;
   // public Text searchTxt;
    public InitialRestSharpSetup RestSharpManager;
    public TextMeshProUGUI ButtonTestDisplay;
    public void SearchText()
    {
        var messageToUser = "Error Occured";
        var questionAsk = SearchTextInputFeld.text.ToString();
        var resultAnswer = RestSharpManager.SearchFAQAnswer(questionAsk);
        if (resultAnswer!=null && resultAnswer.Results.Length>1)
        {
            //  messageToUser = "The best Result is " + resultAnswer.Results[0].Faq.Answer + "Confidence Level" + resultAnswer.Results[0].Confidence;
            messageToUser = resultAnswer.Results[0].Faq.Answer;

        }
        Debug.Log(messageToUser);
        ButtonTestDisplay.text = messageToUser;
    }


}

