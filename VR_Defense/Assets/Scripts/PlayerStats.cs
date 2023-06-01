using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerStats : MonoBehaviour
{
    

    public static int Money;
    public int starMoney = 400;

    public static int Lives;
    public int starLives = 4;

    void Start()
    {
        Money = starMoney;

        Lives = starLives;
    }

  

}
