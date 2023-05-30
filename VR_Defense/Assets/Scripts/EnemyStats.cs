using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour
{


    public float health = 100f;

    public Slider healthBar;

    private void Update()
    {
        healthBar.value = health;
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        

        if(health <= 0)
        {
            EnemyDie();
        }
    }


    public void EnemyDie()
    {
        PlayerStats.Money += 100;
        Destroy(gameObject);
        WaveSpawner.enemyalive--;
    }

    public void EnemyWin()
    {
        Destroy(gameObject);
        WaveSpawner.enemyalive--;
        PlayerStats.Lives--;
        Debug.Log("-1 vida");
    }
   




}
