using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //enemy can move
    public float enemySpeed = 5.0f;
    private Rigidbody enemyRb;
    private GameObject player;
    private GameManager gameManager;

    public ParticleSystem enemyExplosionParticle;
    public ParticleSystem barrierExplosionParticle;
    public ParticleSystem playerExplosionParticle;

    private PlayerController playerScript;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.MovePosition(enemyRb.position + lookDirection * enemySpeed * Time.deltaTime);
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Barrier"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Instantiate(barrierExplosionParticle, transform.position, barrierExplosionParticle.transform.rotation);
        }

        if (other.gameObject.CompareTag("Projectile"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            gameManager.UpdateScore(5);
            Instantiate(enemyExplosionParticle, transform.position, enemyExplosionParticle.transform.rotation);
        }

        if (other.gameObject.CompareTag("Player") && playerScript.isInvincible == false)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Instantiate(playerExplosionParticle, transform.position, playerExplosionParticle.transform.rotation);
        }
    }
}
