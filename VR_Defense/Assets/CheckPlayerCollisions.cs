using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class CheckPlayerCollisions : MonoBehaviour
{
    //public GameObject toyBombTower;
    //public GameObject toyArrowTower;

    //public XRSocketInteractor bombSocket;
    //public XRSocketInteractor arrowSocket;


    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Player")
        {
            //Debug.Log("PlayerCollider");
            //toyArrowTower.transform.position = arrowSocket.transform.position;
            //toyBombTower.transform.position = bombSocket.transform.position;

            //gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
       //if (other.gameObject.tag == "Player")
            //gameObject.GetComponent<BoxCollider>().enabled = true;
       
    }
}
