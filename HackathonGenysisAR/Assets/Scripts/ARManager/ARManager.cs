using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARManager : MonoBehaviour
{
    public GameObject[] PreVideoPlayList;
    public string[] PreAnswers;

    private int IndexCount=-1;

    // Start is called before the first frame update
    void Start()
    {
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
        }
        else
        {
            /////TODO DISPLAY TEXT
        }
    }

    private void DisableAllVideos()
    {
        for (int i = 0; i < PreVideoPlayList.Length; i++)
        {
            PreVideoPlayList[i].SetActive(false);
        }
    }
}
