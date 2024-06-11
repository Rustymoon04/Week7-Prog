using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float timeToSpawn;
    public GameObject enemyToSpawn;
    private float baseTime;

    private void Start()
    {
        baseTime = timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        timeToSpawn -= Time.deltaTime;
        if (timeToSpawn <=0)
        {
            Instantiate(enemyToSpawn,transform.position,Quaternion.identity);
            timeToSpawn = baseTime;
        }
    }
}
