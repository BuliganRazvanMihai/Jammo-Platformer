using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemRuby : MonoBehaviour
{
    public GameObject Scorebox;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        Score.currentScore += 100;
        collectSound.Play();
        Destroy(gameObject);
    }

}
