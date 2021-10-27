using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    //defines boundaries for easy editing of document later
    private float topBoundary = 30.0f;
    private float bottomBoundary = -15.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //defines what happens when something tries to go out of the boundaries
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        }
        //if an animal passes the player then it is game over
        else if (transform.position.z < bottomBoundary)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
