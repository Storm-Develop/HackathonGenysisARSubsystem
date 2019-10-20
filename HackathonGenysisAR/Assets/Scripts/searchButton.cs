using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SearchButton : MonoBehaviour
{
    public InputField SearchTextInputFeld;
    public InitialRestSharpSetup RestSharpManager;
    public TextMeshProUGUI ButtonTestDisplay;
    public string DefaultErrorAnswer= "We are sorry, we currently do not have an answer to your question. Please try again at a later time.";
    public void SearchText()
    {
        var questionAsk = SearchTextInputFeld.text.ToString();
        var messageToUser = SearchQuestion(questionAsk);
        Debug.Log(messageToUser);
        AnswerShared.SharedAnsw = ButtonTestDisplay.text = messageToUser;
    }
    public void SearchAudioText(string questionAsk)
    {
        var messageToUser = SearchQuestion(questionAsk);
        Debug.Log(messageToUser);
        AnswerShared.SharedAnsw = ButtonTestDisplay.text = messageToUser;
    }
    private string SearchQuestion(string questionAsk)
    {
        var messageToUser = DefaultErrorAnswer;
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

