using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{

    public TextMeshProUGUI livesUI;
    public GameObject button;
    
    void Start()
    {
        button.SetActive(false);
    }




    void Update()
    {

        if (PlayerStats.Lives > 0)
        {
            livesUI.text = "Hits To Lose: " + PlayerStats.Lives.ToString();
        }
        else
        {
            livesUI.text = "You Lose";
            button.SetActive(true);
        }
            


    }
}
