using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ArrowLogic : MonoBehaviour
{

    float maxStrenght = 0.2f;

    private void Update()
    {
        if (gameObject.transform.position.y < -5)
            Destroy(gameObject);

        if (ArrowShoot.arrowShooted && gameObject.layer == 8)
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.AddForce(gameObject.transform.forward * maxStrenght, ForceMode.Impulse);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.gameObject.tag == "Floor")
        {
            ArrowShoot.arrowShooted = false;
        }

    }

}