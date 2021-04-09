using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using Character;

public class PauseEvent : MonoBehaviour
{
    private PlayerController PlayerController;
    public GameObject PauseMenuUI;
    public GameObject Player;
    //public static bool GameIsPaused = false;

    private void Awake()
    {
        PlayerController = GetComponent<PlayerController>();
    }
    public void OnResume(InputValue value)
    {
        ResumeGame();
    }
    public void OnPause(InputValue value)
    {
        PlayerController.IsPaused = value.isPressed;
        Pause();
    }
    public void OnMainMenu(InputValue value)
    {
        PlayerController.IsBackToMainMenu = value.isPressed;
        MainMenu();
    }

    public void ResumeGame()
    {
        PauseMenuUI.SetActive(false);

        PlayerController.IsPaused = false;
        //PlayerController.IsResume = true;
        Player.SetActive(true);
        AppEvents.Invoke_OnMouseCursorEnable(false);
    }
    public void Pause()
    {
        PlayerController.IsPaused = true;
        Player.SetActive(false);
        PauseMenuUI.SetActive(true);
        AppEvents.Invoke_OnMouseCursorEnable(true);
    }
    public void MainMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
        AppEvents.Invoke_OnMouseCursorEnable(true);
    }
    public void Quit()
    {
        Application.Quit();
    }    
}
