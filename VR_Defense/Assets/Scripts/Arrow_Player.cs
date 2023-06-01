using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Player : MonoBehaviour
{
    public float damage = 50f;
  

    public GameObject impactEffect;

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Damage(collision.transform);
        }

    }

    public void Damage(Transform enemy)
    {
        EnemyStats e = enemy.GetComponent<EnemyStats>();

        if (e != null)
        {
            e.TakeDamage(damage);
        }
    }
    

}
