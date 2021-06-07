using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject optionsPanel;

    public void Pause() 
    {
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
    }

    public void ReturnMainmenu()
    {
        Time.timeScale = 1;
        ScoreScript.scorevalue = 0;
        SceneManager.LoadScene("MainMenu");
    }

    public void Quitgame()
    {
        Application.Quit();
    }
}
