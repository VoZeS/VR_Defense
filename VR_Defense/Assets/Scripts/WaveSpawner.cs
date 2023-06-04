using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 2f;
    //private float countdown = 2f;

    public int waveIndex;

    public static int enemyalive;


    public static  bool endOrd = true;


    public GameObject floor;

    private void Start()
    {
        waveIndex = 0;
        enemyalive = 0;
    }

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

        if (endOrd == true)
        {
            floor.transform.position = new Vector3(38, 15, 38);
        }

        if (endOrd == false)
        {
            floor.transform.position = new Vector3(38, 15.5f, 38);
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
