﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnteranceScene : MonoBehaviour
{
    //public Button play;
    //public Button exit;

    private void Start()
    {
        // Button playBtn = play.GetComponent<Button>();
        // playBtn.onClick.AddListener(LoadGameScene);
        // Button exitBtn = exit.GetComponent<Button>();
        // exitBtn.onClick.AddListener(QuitTheGame);
        
    }

    public void LoadGameScene() => SceneManager.LoadScene("Level1");
    public void QuitTheGame() => Application.Quit();
}
