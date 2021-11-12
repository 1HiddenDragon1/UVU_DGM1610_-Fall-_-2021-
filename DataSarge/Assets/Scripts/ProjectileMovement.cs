using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public float projectileSpeed = 5.0f;
    private Rigidbody projectileRB;

    // Start is called before the first frame update
    void Start()
    {
        projectileRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        projectileRB.AddForce(Vector3.forward * projectileSpeed);
    }
}
