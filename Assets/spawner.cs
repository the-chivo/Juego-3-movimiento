using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject enemy;
    [SerializeField] List<Transform> spawnPoints;
    float time = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= 5)
        {
            GameObject.Instantiate(enemy,spawnPoints[UnityEngine.Random.Range(0, spawnPoints.Count)].position, Quaternion.identity);
            time = 0;
        }

        
        
    }
}
