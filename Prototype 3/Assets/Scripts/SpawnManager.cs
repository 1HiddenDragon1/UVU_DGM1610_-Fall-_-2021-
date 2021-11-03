using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(28, 0, 0);
    private float startDelay = 2f;
    private float spawnTimer = 2f;
    private PlayerMovement playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        //repeatedly generates objects
        InvokeRepeating("SpawnObstacle", startDelay, spawnTimer);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        //gameobjects are only created when game is playing
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
