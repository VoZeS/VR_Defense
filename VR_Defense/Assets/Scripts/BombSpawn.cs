using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawn : MonoBehaviour
{
    public GameObject spawn;
    public GameObject bomb;

    public int maxBombs = 2;
    public static int currentBombs = 0;

    private void OnTriggerExit(Collider other)
    {
        if(/*other.gameObject.tag == "Bomb"*/ bomb && currentBombs < maxBombs)
        {
            Instantiate(bomb, spawn.transform.position, spawn.transform.rotation);
            currentBombs++;
            Debug.Log(currentBombs);
        }
    }
}
