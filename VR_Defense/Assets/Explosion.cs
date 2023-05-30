using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject damageArea;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Explode();
    }

    void Explode()
    {
        GameObject explosionGO = (GameObject)Instantiate(damageArea, gameObject.transform.position, gameObject.transform.rotation);
    
    }



}
