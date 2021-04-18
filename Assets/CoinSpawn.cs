using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject CoinPrefab;
    public float spawnTime;
    public float randomMin;
    public float randomMax;
    private float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        spawnDelay = Random.Range(randomMin, randomMax);
        InvokeRepeating("SpawnCoin", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCoin()
    {
        Instantiate(CoinPrefab, transform.position, transform.rotation);
    }
}
