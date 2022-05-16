using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMines : MonoBehaviour
{
    public GameObject mine;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randX = Random.Range(minX,maxX);
        float randY = Random.Range(minY,maxY);

        Instantiate(mine, transform.position + new Vector3(randX,randY,0),transform.rotation);
    }
}
