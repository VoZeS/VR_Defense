using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{

    public TextMeshProUGUI livesUI;
    public GameObject button;

    public AudioSource looseSource;
    public AudioClip audioClip;

    private int numberOfTimesPlayed = 0;

    void Start()
    {
        button.SetActive(false);

        numberOfTimesPlayed = 0;
    }

    void Update()
    {

        if (PlayerStats.Lives > 0)
        {
            livesUI.text = "Hits To Lose: " + PlayerStats.Lives.ToString();
        }
        else
        {
            if(!looseSource.isPlaying && numberOfTimesPlayed == 0)
            {
                looseSource.PlayOneShot(audioClip);
                numberOfTimesPlayed++;

            }

            livesUI.text = "You Lose";
            button.SetActive(true);
        }
            


    }
}
