using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SearchButton : MonoBehaviour
{
    public GameObject ARscene;
    public InputField SearchTextInputFeld;
    public InitialRestSharpSetup RestSharpManager;
    public TextMeshProUGUI ButtonTestDisplay;
    public void SearchText()
    {
        var questionAsk = SearchTextInputFeld.text.ToString();
        var messageToUser = SearchQuestion(questionAsk);
        Debug.Log(messageToUser);
        AnswerShared.SharedAnsw = ButtonTestDisplay.text = messageToUser;
    }

    private string SearchQuestion(string questionAsk)
    {
        var messageToUser = "Error Occured";
        var resultAnswer = RestSharpManager.SearchFAQAnswer(questionAsk);
        if (resultAnswer != null && resultAnswer.Results.Length > 1)
        {
            //  messageToUser = "The best Result is " + resultAnswer.Results[0].Faq.Answer + "Confidence Level" + resultAnswer.Results[0].Confidence;
            messageToUser = resultAnswer.Results[0].Faq.Answer;
        }
        return messageToUser;
    }

    public void LoadARMenu()
    {
        SceneManager.LoadScene("ARSceneVideos");
    }
}

