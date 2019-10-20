using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARManager : MonoBehaviour
{
    public GameObject[] PreVideoPlayList;
    public string[] PreAnswers;
    public string SharedAnswer;

    private int IndexCount;

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
            if(PreAnswers[i].Contains(SharedAnswer))
            {
                IndexCount = i;
            }
        }
        PreVideoPlayList[i].SetActive(true);
    }

    private void DisableAllVideos()
    {
        for (int i = 0; i < PreVideoPlayList.Length; i++)
        {
            PreVideoPlayList[i].SetActive(false);
        }
    }
}
