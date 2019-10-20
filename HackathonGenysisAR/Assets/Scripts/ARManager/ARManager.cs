using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARManager : MonoBehaviour
{
    public GameObject[] PreVideoPlayList;
    public TextMeshProUGUI UICanvasDisplay;
    public string[] PreAnswers;
    public string[] ActualAnswers;
    public string AnswerOutput;
    private int IndexCount=-1;

    // Start is called before the first frame update
    void Start()
    {
        AnswerOutput = AnswerShared.SharedAnsw;
        CompareWhichVideoToPlay();
    }

    private void CompareWhichVideoToPlay()
    {
        DisableAllVideos();
        for (int i=0; i< PreAnswers.Length;i++)
        {
            if(AnswerShared.SharedAnsw.Contains(PreAnswers[i]))
            {
                IndexCount = i;
            }
        }
        if(IndexCount>=0)
        {
            PreVideoPlayList[IndexCount].SetActive(true);
            AnswerShared.SharedAnsw = ActualAnswers[IndexCount];
        }
        ///TODO Make Speech To Text Call Here
        UICanvasDisplay.text = AnswerShared.SharedAnsw;
    }

    private void DisableAllVideos()
    {
        for (int i = 0; i < PreVideoPlayList.Length; i++)
        {
            PreVideoPlayList[i].SetActive(false);
        }
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainScene");
    }
}
