using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBombSocketTrigger : MonoBehaviour
{
    public static bool isInsideBombSocket = false;

    private void OnCollisionEnter(Collision collision)
    {
        isInsideBombSocket = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isInsideBombSocket = false;
    }
}
