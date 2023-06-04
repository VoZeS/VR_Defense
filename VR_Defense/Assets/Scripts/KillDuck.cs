using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillDuck : MonoBehaviour
{

    private void Start()
    {
<<<<<<< Updated upstream
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        gameObject.GetComponent<Animator>().enabled = true;
=======
        //if (ChangeMode.buildMode == true)
        //{
        //    gameObject.GetComponent<Rigidbody>().useGravity = false;
        //    gameObject.GetComponent<Animator>().enabled = true;
        //}
>>>>>>> Stashed changes
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Arrow")
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            gameObject.GetComponent<Animator>().enabled = false;

            PlayerStats.Lives++;
        }
    }
}
