using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pause : MonoBehaviour
{
    public GameObject Shade;
    public Button resumeButton;
    public Button LoadButton;
    public Button SaveButton;
    public Button NewGameButton;
    public Button JsonButton;
    public Toggle music;
    public static bool isPaused = false;

    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }  
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        Shade.gameObject.SetActive(true);
        resumeButton.gameObject.SetActive(true);
        SaveButton.gameObject.SetActive(true);
        LoadButton.gameObject.SetActive(true);
        NewGameButton.gameObject.SetActive(true);
        JsonButton.gameObject.SetActive(true);
        music.gameObject.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        Shade.gameObject.SetActive(false);
        resumeButton.gameObject.SetActive(false);
        SaveButton.gameObject.SetActive(false);
        LoadButton.gameObject.SetActive(false);
        NewGameButton.gameObject.SetActive(false);
        JsonButton.gameObject.SetActive(false);
        music.gameObject.SetActive(false);
    }
}