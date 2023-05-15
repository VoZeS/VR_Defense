using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    public int waveIndex = 0;

    void Update()
    {
        if (ChangeMode.orda)
        {

            if ( countdown <= 0f)
            {
                StartCoroutine (SpawnWave());
                countdown = timeBetweenWaves;
            }

        countdown -= Time.deltaTime;

        }
    }

    IEnumerator SpawnWave()
    {
        //Debug.Log("Wave Incoming");
        waveIndex++;

       for( int i = 0; i < waveIndex; i++) 
        {
            
                SpawnEnemy();
                yield return new WaitForSeconds (0.5f);
          
        }
     
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

}
