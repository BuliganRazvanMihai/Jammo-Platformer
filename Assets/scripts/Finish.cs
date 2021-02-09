using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    //public GameObject youWon;
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;

    //for ending text
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public int timeCalc;
    public int scoreCalc;
    public int totalScored;
    public GameObject levelBlocker;

    void OnTriggerEnter()
    {
        levelBlocker.SetActive(true);
        levelBlocker.transform.parent = null;
        timeCalc = Timer.extendScore * 10;
        timeLeft.GetComponent<Text>().text = "Time Left: " + Timer.extendScore + " x 10";
        theScore.GetComponent<Text>().text = "Score: " + Score.currentScore;
        totalScored = Score.currentScore + timeCalc;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore());
       // StartCoroutine(YouWon());
    }

    //IEnumerator YouWon() {
    //    youWon.SetActive(true);
    //    yield return new WaitForSeconds(3);
    //    SceneManager.LoadScene(0);
    //}

    IEnumerator CalculateScore() {
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        theScore.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(4.75f);
        SceneManager.LoadScene(0);
    }
}
