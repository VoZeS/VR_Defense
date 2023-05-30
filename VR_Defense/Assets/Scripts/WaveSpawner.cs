using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 2f;
    //private float countdown = 2f;

    public int waveIndex = 0;

    public static int enemyalive = 0;


    public static  bool endOrd = true;

   

    void Update()
    {
        if (enemyalive <= 0)
        {
            endOrd = true;
        }
 
        if (ChangeMode.buildMode == false && endOrd)
        {
                StartCoroutine (SpawnWave());
            endOrd = false;
        }

        

    }

    IEnumerator SpawnWave()
    {
        Debug.Log("Wave Incoming");
        waveIndex++;
       

       for( int i = 0; i < waveIndex; i++) 
        {
            
                SpawnEnemy();

            yield return new WaitForSeconds (0.5f);

             SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }

        ChangeMode.buildMode = true;
     
    }

    void SpawnEnemy()
    {
        enemyalive++;
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

}
