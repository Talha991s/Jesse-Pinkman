using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(1);

    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        AppEvents.Invoke_OnMouseCursorEnable(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
