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
    //public static bool GameIsPaused = false;

    private void Awake()
    {
        PlayerController = GetComponent<PlayerController>();
    }
    public void OnResume(InputValue value)
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
       PlayerController.IsResume = false;
    }
    public void OnPause(InputValue value)
    {
        Time.timeScale = 0.0f;
        PlayerController.IsPaused= value.isPressed;
        PauseMenuUI.SetActive(true);
    }
    public void OnMainMenu(InputValue value)
    {
        PlayerController.IsBackToMainMenu = value.isPressed;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
}
