using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //player input
    private float speed = 18.0f;
    private float turnSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //sources for player movement
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        
        //move the vehicle forward. based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //turns the vehicle on its axis. based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
