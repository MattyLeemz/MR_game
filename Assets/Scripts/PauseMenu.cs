using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;

    public bool GameIsPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused == true)
            {
                Resume();
                // Debug.Log("Trying to resume here." + GameIsPaused);
            }
            else
            {
                // Debug.Log("Trying to pause here" + GameIsPaused);
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        GameIsPaused = true;
        Time.timeScale = 0f;
    }
}
