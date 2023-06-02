using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionLimits : MonoBehaviour
{
    public Transform attachSocket;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
            gameObject.transform.position = attachSocket.position;

    }
}
