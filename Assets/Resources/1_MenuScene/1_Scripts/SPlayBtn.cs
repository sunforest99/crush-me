﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SPlayBtn : MonoBehaviour
{
    public Animator[] StartAni = null;

    public GameObject TitleGams = null;

    public SpriteRenderer TitleSr = null;

    public bool bTitleAlpha = false;

    private void Update()
    {
        if (bTitleAlpha)
            TitleSr.color -= new Color(0f, 0f, 0f, 0.1f);
    }

    public void PlayBtn()
    {
        //StartAni[0].enabled = true;
        //StartAni[1].enabled = true;
        //StartAni[2].enabled = true;

        for (int i = 0; i < StartAni.Length; i++)
        {
            StartAni[i].enabled = true;
        }

        //TitleGams.SetActive(false);
        //TitleSr.color -= new Color(0f, 0f, 0f, 0.01f);
        bTitleAlpha = true;
    }
}
