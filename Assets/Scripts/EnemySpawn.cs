using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public int WaveSize;

    public GameObject EnemyPrefab;

    public float EnemyInterval;

    public Transform SpawnPoint;

    public float StartTime;

    public Transform[] WayPoints;

    private int _enemyCount = 0;


	void Start ()
	{
	    InvokeRepeating("SpawnEnemy", StartTime, EnemyInterval);
	}
	
	// Update is called once per frame
	void Update () {
	    if (_enemyCount == WaveSize)
	    {
	        CancelInvoke("SpawnEnemy");
	    }
	}

    void SpawnEnemy()
    {
        _enemyCount++;
        var enemy = Instantiate(EnemyPrefab, SpawnPoint.position, Quaternion.identity);
        enemy.GetComponent<MoveEnemy>().WayPoints = WayPoints;
    }
}
