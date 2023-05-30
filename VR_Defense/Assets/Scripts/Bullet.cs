using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public float damage = 0f;

    public float explosionRadius = 0f;

    public float speed = 0f;

    public EnemyStats enemyStats;

    public void Seek(Transform _target)
    {
        target = _target;
    }


    private void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame,Space.World);
        transform.LookAt(target);
    }


    void HitTarget()
    {
       if(explosionRadius > 0f)
        {
            Explode();
        }

        else
        {
            Damage(target);
        }

        Destroy(gameObject);
    }

    void Damage (Transform enemy)
    {
       EnemyStats e = enemy.GetComponent<EnemyStats>();

        if (e != null)
        {
            e.TakeDamage(damage);
        }
    }


    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.tag == "Enemy")
            {
                Damage(collider.transform);
            }
        }
    }
}
