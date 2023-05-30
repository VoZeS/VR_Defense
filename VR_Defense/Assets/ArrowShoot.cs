using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShoot : MonoBehaviour
{
    private Transform target;
    public GameObject arrow;

    public float speed = 10f;
    private bool arrowInPosition = false;
    private bool arrowShooted = false;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    public void SetArrowInPosition(System.Boolean active)
    {
        arrowInPosition = active;
    }

    void Update()
    {

        if(arrowShooted)
        {
            Vector3 dir = arrow.transform.forward;
            float distanceThisFrame = speed * Time.deltaTime;

            if (dir.magnitude <= distanceThisFrame)
            {
                HitTarget();
                return;
            }
            arrow.transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        }
       
    }

    public void ShootArrow()
    {
        if(arrowInPosition)
        {
            arrowShooted = true;
            arrowInPosition = false;
        }
    }

    void HitTarget()
    {
        WaveSpawner.enemyalive--;
        PlayerStats.Money += 100;
        Destroy(target.gameObject);
        Destroy(arrow);
        arrowShooted = false;
    }
}
