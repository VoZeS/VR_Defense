using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public GameObject moneyUI;

    public static int Money;
    public int starMoney = 400;

    public static int Lives;
    public int starLives = 4;

    void Start()
    {
        Money = starMoney;

        Lives = starLives;
    }

    void Update()
    {
       moneyUI.GetComponent<TextMesh>().text = " " + Money.ToString();
    }

}
