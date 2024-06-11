using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed = 10;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * (Time.deltaTime * enemySpeed));
    }
}
