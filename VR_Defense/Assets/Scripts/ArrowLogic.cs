using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ArrowLogic : MonoBehaviour
{
    float maxStrenght = 0.2f;

    public bool isReady = false;
    public static bool arrowShooted = false;

    private Rigidbody rb;
    private void Start()
    {
        arrowShooted = false;
        isReady = false;

        rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        if (gameObject.transform.position.y < -5)
            Destroy(gameObject);

        if (arrowShooted && isReady)
        {
            Debug.Log("SHOOOT!");

            rb.AddForce(transform.forward * maxStrenght, ForceMode.Impulse);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //arrowShooted = false;

        if(collision.gameObject.tag == "Floor")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Crossbow")
        {
            isReady = true;
        }


    }

    private void OnCollisionExit(Collision collision)
    {
       
        if (collision.gameObject.tag == "Crossbow")
        {
            isReady = false;
        }


    }
}