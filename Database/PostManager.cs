﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostManager : MonoBehaviour
{
    public static string imageUrl, postTag, postTitle, postDescription, postDate;
    DateTime m_currentDate = DateTime.Now;
    public InputField postTagInput, postTitleInput, postDescriptionInput;
    public Button sendPostButton;

    private void Start()
    {
        postDate = m_currentDate.Date.ToString();
        imageUrl = "";

        sendPostButton.onClick.AddListener(() => SendPost());
    }

    private void Update()
    {
        postTag = postTagInput.text;
        postTitle = postTitleInput.text;
        postDescription = postDescriptionInput.text;

        CheckFormInputPost();
    }

    private void SendPost()
    {
        Post post = new Post();
        DatabaseManager.sharedInstance.CreateNewPost(post);
        Debug.Log("Send Post: " + postTag + ", " + postTitle + ", " + postDescription + ", " + postDate);
    }

    private void CheckFormInputPost()
    {
        if(postTagInput.text != "" && postTitleInput.text.Length >= 5 && postDescriptionInput.text.Length >= 25)
        {
            sendPostButton.interactable = true;
        }
        else
        {
            sendPostButton.interactable = false;
        }
    }
}
