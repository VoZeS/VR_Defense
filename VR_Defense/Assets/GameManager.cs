using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private void Update()
    {
        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }


    void EndGame()
    {
        Debug.Log("Game Over");

        ChangeMode.buildMode = true;
    }
}
