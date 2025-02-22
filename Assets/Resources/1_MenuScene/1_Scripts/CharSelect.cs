﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelect : MonoBehaviour
{
    public UnityEngine.UI.Image[] CharLockImg;
    public GameObject CharSelectObj;
    public GameObject[] CharObj;
    public SpriteRenderer RocketSr;
    public Sprite[] CharSprite = null;

    public Color CharColor = new Color(255f, 255f, 255f, 255f);

    public void Start()
    {
        for (int i = 1; i < SSoundMng.I.bCharLock.Length; i++)
        {
            if (SSoundMng.I.bCharLock[i])
                CharLockImg[i - 1].gameObject.SetActive(false);
            else
                CharLockImg[i - 1].gameObject.SetActive(true);
        }
        switch (SSoundMng.I.nCharNum)
        {
            case 0:
                SelectFrame(SSoundMng.I.nCharNum, 0);
                break;
            case 2:
                SelectFrame(SSoundMng.I.nCharNum, 2);
                break;
            case 8:
                SelectFrame(SSoundMng.I.nCharNum, 3);
                break;
            default:
                SelectFrame(SSoundMng.I.nCharNum, 1);
                break;
        }
    }
    void CharUnLock(int idx, int credit)
    {
        SSoundMng.I.credit -= credit;
        SSoundMng.I.bCharLock[idx] = true;
        SSoundMng.I.nCharNum = idx;
        CharLockImg[idx - 1].gameObject.SetActive(false);
        switch (SSoundMng.I.nCharNum)
        {
            case 0:
                SelectFrame(SSoundMng.I.nCharNum, 0);
                break;
            case 2:
                SelectFrame(SSoundMng.I.nCharNum, 2);
                break;
            case 8:
                SelectFrame(SSoundMng.I.nCharNum, 3);
                break;
            default:
                SelectFrame(SSoundMng.I.nCharNum, 1);
                break;
        }
    }

    public void SelectFrame(int idx, int spriteidx = 1)
    {
        RocketSr.sprite = CharSprite[spriteidx];
        CharSelectObj.transform.parent = CharObj[idx].transform;
        CharSelectObj.transform.localPosition = Vector2.zero;
        switch (idx)
        {
            case 0:
            case 1:
            case 2:
            case 8:
                CharColor = new Color(255f, 255f, 255f, 255f);
                break;
            case 3:
                CharColor = new Color(210 / 255f, 68 / 255f, 68 / 255f, 255f);
                break;
            case 4:
                CharColor = new Color(84 / 255f, 105 / 255f, 248 / 255f, 255f);
                break;
            case 5:
                CharColor = new Color(230 / 255f, 233 / 255f, 56 / 255f, 255f);
                break;
            case 6:
                CharColor = new Color(62 / 255f, 220 / 255f, 227 / 255f, 255f);
                break;
            case 7:
                CharColor = new Color(169 / 255f, 169 / 255f, 169 / 255f, 255f);
                break;
        }
        RocketSr.color = CharColor;
    }

    public void Char0()
    {
        SSoundMng.I.nCharNum = 0;
        SelectFrame(0, 0);
        Debug.Log("기본");
    }

    public void Char1()
    {
        if (SSoundMng.I.bCharLock[1])
        {
            SSoundMng.I.nCharNum = 1;
            SelectFrame(1, 1);
            Debug.Log("초록");
        }
        else
        {
            if (SSoundMng.I.credit >= 100)
            {
                CharUnLock(1, 100);
            }
            else if (SSoundMng.I.credit < 100)
            {
                Debug.Log("크레딧이 부족합니다.");
            }

        }
        Debug.Log(SSoundMng.I.bCharLock[1]);
        Debug.Log(SSoundMng.I.credit);
    }

    public void Char2()
    {
        if (SSoundMng.I.bCharLock[2])
        {
            SSoundMng.I.nCharNum = 2;
            SelectFrame(2, 2);
            Debug.Log("보라");
        }
        else
        {
            if (SSoundMng.I.credit >= 100)
            {
                CharUnLock(2, 100);
            }
            else if (SSoundMng.I.credit < 100)
            {
                Debug.Log("크레딧이 부족합니다.");
            }

        }
        Debug.Log(SSoundMng.I.bCharLock[2]);
        Debug.Log(SSoundMng.I.credit);
    }

    public void Char3()
    {
        if (SSoundMng.I.bCharLock[3])
        {
            SSoundMng.I.nCharNum = 3;
            SelectFrame(3);
            Debug.Log("빨강");
        }
        else
        {
            if (SSoundMng.I.credit >= 100)
            {
                CharUnLock(3, 100);
            }
            else if (SSoundMng.I.credit < 100)
            {
                Debug.Log("크레딧이 부족합니다.");
            }

        }
        Debug.Log(SSoundMng.I.bCharLock[3]);
    }

    public void Char4()
    {
        if (SSoundMng.I.bCharLock[4])
        {
            SSoundMng.I.nCharNum = 4;
            SelectFrame(4);
            Debug.Log("파랑");
        }
        else
        {
            if (SSoundMng.I.credit >= 100)
            {
                CharUnLock(4, 100);
            }
            else if (SSoundMng.I.credit < 100)
            {
                Debug.Log("크레딧이 부족합니다.");
            }

        }
        Debug.Log(SSoundMng.I.bCharLock[4]);
    }

    public void Char5()
    {
        if (SSoundMng.I.bCharLock[5])
        {
            SSoundMng.I.nCharNum = 5;
            SelectFrame(5);
            Debug.Log("노랑");
        }
        else
        {
            if (SSoundMng.I.credit >= 100)
            {
                CharUnLock(5, 100);
            }
            else if (SSoundMng.I.credit < 100)
            {
                Debug.Log("크레딧이 부족합니다.");
            }

        }
        Debug.Log(SSoundMng.I.bCharLock[5]);
    }

    public void Char6()
    {
        if (SSoundMng.I.bCharLock[6])
        {
            SSoundMng.I.nCharNum = 6;
            SelectFrame(6);
            Debug.Log("하늘");
        }
        else
        {
            if (SSoundMng.I.credit >= 100)
            {
                CharUnLock(6, 100);
            }
            else if (SSoundMng.I.credit < 100)
            {
                Debug.Log("크레딧이 부족합니다.");
            }

        }
        Debug.Log(SSoundMng.I.bCharLock[6]);
    }

    public void Char7()
    {
        if (SSoundMng.I.bCharLock[7])
        {
            SSoundMng.I.nCharNum = 7;
            SelectFrame(7);
            Debug.Log("회색");
        }
        else
        {
            if (SSoundMng.I.credit >= 100)
            {
                CharUnLock(7, 100);
            }
            else if (SSoundMng.I.credit < 100)
            {
                Debug.Log("크레딧이 부족합니다.");
            }

        }
        Debug.Log(SSoundMng.I.bCharLock[7]);
    }

    public void Char8()
    {
        if (SSoundMng.I.bCharLock[8])
        {
            SSoundMng.I.nCharNum = 8;
            SelectFrame(8, 3);
            Debug.Log("스뼤샬");
        }
        else
        {
            if (SSoundMng.I.credit >= 100)
            {
                CharUnLock(8, 100);
            }
            else if (SSoundMng.I.credit < 100)
            {
                Debug.Log("크레딧이 부족합니다.");
            }

        }
        Debug.Log(SSoundMng.I.bCharLock[8]);
    }
}
