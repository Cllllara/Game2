﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameManager gameManager;

    public void PlayGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void OptionMenu()
    {
        SceneManager.LoadScene("OptionMenu");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("LoadMenu");
    }
}
