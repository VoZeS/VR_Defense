using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMode : MonoBehaviour
{
    public bool orda = false;
    public bool build = true;

    public static bool buildMode = true;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && WaveSpawner.endOrd==true)
        {
            Debug.Log("Cambio Modo");

            BuildingMode();

        }

        if (buildMode == true)
        {
            orda = false;
            build = true;
        }

        if (buildMode == false)
        {
            orda = true;
            build = false;
        }



       

    }

    public void BuildingMode()
    {
        buildMode = false;
    }

   
}
