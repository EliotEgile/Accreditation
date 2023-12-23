using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject unpauseButton;
    public GameObject menuButton;

    public void SetPause()
    {
        if (GameIsPaused)
        {
            Resume();
        }
        else 
        {
            IsPaused();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        unpauseButton.SetActive(true);
        menuButton.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void IsPaused()
    {
        pauseMenuUI.SetActive(true);
        unpauseButton.SetActive(false);
        menuButton.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
