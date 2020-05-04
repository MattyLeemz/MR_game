using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("levelTest");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScreen");
    }
    public void QuitToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("You just Quitted the game.");
        Application.Quit();
    }
}
