using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITowers : MonoBehaviour
{

    public TextMeshProUGUI arrowPriceUI;
    public TextMeshProUGUI bombPriceUI;

    public TextMeshProUGUI moneyUI;
    public TextMeshProUGUI enemiesUI;


    void Update()
    {

        enemiesUI.text = "Enemies Alive: " + WaveSpawner.enemyalive.ToString();
        moneyUI.text = "Current Gold: " + PlayerStats.Money.ToString();

        arrowPriceUI.text = "Price: " + Node.arrowTowerPrice.ToString();
        bombPriceUI.text = "Price: " + Node.bombTowerPrice.ToString();



    }
}
