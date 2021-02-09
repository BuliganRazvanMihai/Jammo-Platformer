using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject timeDisplay;
    public GameObject timeDisplay1;
    public bool isTakingTime = false;
    public int Seconds = 180;
    public static int extendScore;



    void Update()
    {
        extendScore = Seconds;

        if (isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }


    }

    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        Seconds -= 1;
        timeDisplay.GetComponent<Text>().text = "" + Seconds;
        timeDisplay1.GetComponent<Text>().text = "" + Seconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }
}
