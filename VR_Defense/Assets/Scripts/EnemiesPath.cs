using UnityEngine;
using UnityEngine.UI;


public class EnemiesPath : MonoBehaviour
{
    public EnemyStats enemyStats;
    public float speed = 5f; 
    private Transform target;

    private int waypointIndex = 0;

    private void Start()
    {
        target = WayPoints.points[0];
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if(waypointIndex >= WayPoints.points.Length - 1)
        {
            EndPath();
            return;
        }

        waypointIndex++;

        target = WayPoints.points[waypointIndex];
    }

    void EndPath()
    {

       
        enemyStats.EnemyWin();
      
    }



}
