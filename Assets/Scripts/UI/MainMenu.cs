using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource Click;
    public void OnPressPlay()
    {
        Click.Play();
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }
    public void QuitGame()
    {
        Click.Play();
        Application.Quit();
    }
 
}
