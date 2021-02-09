using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Redirection : MonoBehaviour
{
    public static int redirectToLevel;

    void Update() {
        if (redirectToLevel == 1) {
            SceneManager.LoadScene(redirectToLevel);
        }
    }
}
