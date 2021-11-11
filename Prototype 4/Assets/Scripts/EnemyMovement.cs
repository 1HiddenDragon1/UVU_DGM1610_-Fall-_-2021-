using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //enemy speed is set and enemy rigid body and player are set in the script
    public float speed = 1.5f;
    private Rigidbody enemyRb;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //enemy rigid body is grabbed and player is found in game heirarchy
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //enemy chases player at a consistent rate
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);

        //enemy is destroyed if it falls off the platform.
        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}