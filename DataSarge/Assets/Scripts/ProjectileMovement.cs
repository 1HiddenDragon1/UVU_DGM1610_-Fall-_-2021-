using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public float projectileSpeed = 5.0f;

    private Rigidbody projectileRB;
    private GameObject player;
    private GameObject gun;

    private float xBorder = 30;
    private float zBorder = 20;

    // Start is called before the first frame update
    void Start()
    {
        projectileRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        gun = GameObject.Find("Gun");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 projectileTravel = gun.transform.position - player.transform.position;
        projectileRB.AddForce(projectileTravel * projectileSpeed, ForceMode.Impulse);

        ProjectileBorder();
    }

    void ProjectileBorder()
    {
        if (transform.position.z > zBorder)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < -zBorder)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > xBorder)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < -xBorder)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Barrier"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
