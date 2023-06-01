using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillDuck : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Arrow")
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            gameObject.GetComponent<Animator>().enabled = false;
        }
    }
}
