using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMode : MonoBehaviour
{
    public static bool orda = false;
    public static bool build = true;

  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Cambio Modo");
            build = !build;
            orda = !orda;
        }
    }
}
