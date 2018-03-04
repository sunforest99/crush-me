﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour {

    public MenuBtnMng MenuBtnSc = null;

    //public GameObject PlayerBtnGams = null;
    public GameObject CreditPopUpGams = null;

    public Animation EarthAni = null;

    public int nEarthClickNum = 0;

    public bool bEarthTouchAccess = false;
    public bool bEasterEggPlay = false;

	// Use this for initialization
	void Start () {
        EarthAni.Stop();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform.CompareTag("Earth") && !bEarthTouchAccess)
                {
                    EarthAni.Play();
                }
            }
        }

        if (bEasterEggPlay)
        {
            //MenuBtnSc.CreditExit();
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                MenuBtnSc.CreditExit();
            }
        }

        EasterEgg();
    }

    void EasterEgg()
    {
        if (nEarthClickNum == 5 && !bEasterEggPlay)
        {
            //PlayerBtnGams.SetActive(false);
            bEarthTouchAccess = true;
            CreditPopUpGams.SetActive(true);
            bEasterEggPlay = true;
        }
    }

    public void EarthClick()
    {
        nEarthClickNum++;
        SSoundMng.I.Play("Earth", true, false);
    }
}
