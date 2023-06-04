using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour
{

    public GameObject impactEffect;
    public float health = 100f;

    public Slider healthBar;

    public AudioSource audioSource;

    private void Update()
    {
        healthBar.value = health;
    }
    public void TakeDamage(float amount)
    {
        audioSource.Play();

        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 2f);
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
