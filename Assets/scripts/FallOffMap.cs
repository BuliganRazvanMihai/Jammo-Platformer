using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallOffMap : MonoBehaviour
{
    public GameObject youDied;
    public GameObject Scorebox;
    public GameObject LevelAudio;

    void OnTriggerEnter() {
        Score.currentScore = 0;
        StartCoroutine(YouDied());
    }

    IEnumerator YouDied() {
        youDied.SetActive(true);
        LevelAudio.SetActive(false);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
