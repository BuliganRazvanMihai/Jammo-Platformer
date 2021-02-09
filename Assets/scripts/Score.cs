using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject Scorebox;
    public static int currentScore;
    public int internalScore;

  void Update()
    {
        internalScore = currentScore;
        Scorebox.GetComponent<Text>().text = "" + internalScore;
    }
}
