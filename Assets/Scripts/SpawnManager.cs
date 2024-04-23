using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float heightRange = 0.55f;
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float maxTime = 2.5f;
    private float timer;

    private void Start()
    {
        SpawnObstacle();
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            SpawnObstacle();
            timer = 0;
        }
        timer += Time.deltaTime;
    }


    private void SpawnObstacle()
    {
        Vector3 spawnPos = transform.position + new Vector3 (0, Random.Range(-heightRange, heightRange), 0);
        GameObject obstacle = Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);

        Destroy(obstacle, 10f);
    }


}
