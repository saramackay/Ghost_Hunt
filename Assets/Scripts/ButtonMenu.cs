using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadSceneAsync("MainLevel");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
