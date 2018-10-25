﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public static bool revive;

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("SampleScene");
        Player_Movement.isDead = false;
        PauseMenu.PlayerIsDead = false;
        PauseMenu.menuSelector = false;
        revive = true;
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Debug.Log("Game out bro!");

        Application.Quit();
    }
}
