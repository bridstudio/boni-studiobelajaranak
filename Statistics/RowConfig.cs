﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RowConfig : MonoBehaviour
{
    public Text dateTime, exitButtonPressed, failedCount, restartButtonPressed, shapeSelected, timerIdle, timerOnTouch, sceneName;
    public Image tabImage;

    public void Initialise(UserStats userStats)
    {
        this.dateTime.text = userStats.dateTime;
        this.exitButtonPressed.text = userStats.exitButtonPressed;
        this.failedCount.text = userStats.failedCount;
        this.restartButtonPressed.text = userStats.restartButtonPressed;
        this.shapeSelected.text = userStats.shapeSelected;
        this.timerIdle.text = userStats.timerIdle;
        this.timerOnTouch.text = userStats.timerOnTouch;
        this.sceneName.text = userStats.sceneName;        
    }

    void Start()
    {
        ChangeTabColor();
    }

    public void ChangeTabColor()
    {
        if(this.sceneName.text == "App_Home")
        {
            tabImage.color = new Color32(232, 61, 76, 255);
        }
        else if(this.sceneName.text == "App_Game")
        {
            tabImage.color = new Color32(55, 71, 79, 255);
        }
        else if(this.sceneName.text == "App_Stats")
        {
            tabImage.color = new Color32(0, 117, 219, 255);
        }
    }
}
