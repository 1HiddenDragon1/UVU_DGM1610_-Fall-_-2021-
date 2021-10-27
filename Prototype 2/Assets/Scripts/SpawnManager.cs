using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //array of spawning animals created and components made to simplify editing of spawning animal locations
    public GameObject[] AnimalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        //Spawning animals are created on a timer with a delay
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        //spawning animals are given movement capabilities with smarter/cleaner scripting
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, AnimalPrefabs.Length);

        Instantiate(AnimalPrefabs[animalIndex], spawnPos, AnimalPrefabs[animalIndex].transform.rotation);
    }
}
