using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject barrier;
    public GameObject enemy;
    public GameObject invincibility;
    
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;

    private int score;

    private float zEnemySpawn = 12.0f;
    private float xEnemySpawn = 20.0f;
    private float yEnemySpawn = .75f;
    private float zNonHostileSpawn = 5.0f;
    private float xNonHostileSpawn = 10.0f;
    private float yNonHostileSpawn = 1.0f;

    private float enemySpawnTimer = 1.0f;
    private float enemySpawnDelay = 5.0f;
    private float nonHostileSpawnTimer = 5.0f;
    private float nonHostileSpawnDelay = 3.0f;

    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", enemySpawnDelay, enemySpawnTimer);
        InvokeRepeating("SpawnBarrier", nonHostileSpawnDelay, nonHostileSpawnTimer);
        InvokeRepeating("SpawnInvincibility", nonHostileSpawnDelay, nonHostileSpawnTimer);
        
        score = 0;
        UpdateScore(0);
    }


    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindGameObjectWithTag("Player"))
        {
            gameOver = true;
            gameOverText.gameObject.SetActive(true);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    void SpawnEnemy()
    {
        if (gameOver == false)
        {
            float randomX = Random.Range(-xEnemySpawn, xEnemySpawn);
            float randomZ = Random.Range(-zEnemySpawn, zEnemySpawn);

            Vector3 spawnPos = new Vector3(randomX, yEnemySpawn, randomZ);

            Instantiate(enemy, spawnPos, enemy.gameObject.transform.rotation);
        }
    }

    void SpawnBarrier()
    {
        if (gameOver == false)
        {
            float nonHostileRandomX = Random.Range(-xNonHostileSpawn, xNonHostileSpawn);
            float nonHostileRandomZ = Random.Range(-zNonHostileSpawn, zNonHostileSpawn);

            Vector3 spawnNHPos = new Vector3(nonHostileRandomX, yNonHostileSpawn, nonHostileRandomZ);

            Instantiate(barrier, spawnNHPos, barrier.gameObject.transform.rotation);
        }
    }

    void SpawnInvincibility()
    {
        if (gameOver == false)
        {
            float nonHostileRandomX = Random.Range(-xNonHostileSpawn, xNonHostileSpawn);
            float nonHostileRandomZ = Random.Range(-zNonHostileSpawn, zNonHostileSpawn);

            Vector3 spawnNHPos = new Vector3(nonHostileRandomX, yNonHostileSpawn, nonHostileRandomZ);

            Instantiate(invincibility, spawnNHPos, invincibility.gameObject.transform.rotation);
        }
    }

    public void RestartGame()
    {
        EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().name);
    }
}
