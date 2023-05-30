using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_Player : MonoBehaviour
{
    public float damage = 1000f;
   
    public float explosionRadius = 1000f;

    public GameObject impactEffect;

    public void OnCollisionEnter(Collision collision)
    {
        
      Explode();
     
    }

    void Damage(Transform enemy)
    {
        EnemyStats e = enemy.GetComponent<EnemyStats>();

        if (e != null)
        {
            e.TakeDamage(damage);
        }
    }
    

    void Explode()
    {
        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 2f);
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.tag == "Enemy")
            {
                Damage(collider.transform);
            }
        }
        Destroy(gameObject);
    }
}
