using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    public float spawnRange = 9.0f;
    public int enemyCount;
    public int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        //Enemy and powerup are spawned at the beginning of the game
        SpawnEnemyWave(waveNumber);
        Instantiate(powerupPrefab, GenerateSpawnPos(), powerupPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        //enemy is found in the game heirarchy and new waves are started when enemy count = 0
        enemyCount = FindObjectsOfType<EnemyMovement>().Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerupPrefab, GenerateSpawnPos(), powerupPrefab.transform.rotation);
        }
    }

    //Spawn enemy wave is cleaned up and made into a for loop
    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPos(), enemyPrefab.transform.rotation);
        }
    }

    //spawn locations are made random and the return variable is returned to the game script
    private Vector3 GenerateSpawnPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }
}