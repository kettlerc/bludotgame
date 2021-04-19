﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float startingTime;
    private Text theText;


    void Start()
    {
        theText = GetComponent<Text>();
    }

    void Update()
    { 
        startingTime -= Time.deltaTime;
        theText.text = "" + Mathf.Round(startingTime);
        if (startingTime <= 0)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
    }
}
