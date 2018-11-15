using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float Speed;

    public Transform[] WayPoints;

    private int curWayPointIndex = 0;
	
	// Update is called once per frame
	void Update ()
	{
	    if (curWayPointIndex > WayPoints.Length) return;
	    transform.position =
	        Vector3.MoveTowards(transform.position, WayPoints[curWayPointIndex].position, Time.deltaTime * Speed);
	    if (Vector3.Distance(transform.position, WayPoints[curWayPointIndex].position) < 0.5f)
	    {
	        curWayPointIndex++;
	    }

	}
}
