using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScript : MonoBehaviour
{

    public TextMeshProUGUI livesUI;




    void Update()
    {


        livesUI.text = "Hits To Lose: " + PlayerStats.Lives.ToString();


    }
}
