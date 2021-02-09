using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    public void PlayGame() {
        Redirection.redirectToLevel = 3;
        SceneManager.LoadScene(2);
    }

    public void QuitGame() { 
        Application.Quit();
    }

    public void PlayCreds() {
        SceneManager.LoadScene(3);
    }
}
