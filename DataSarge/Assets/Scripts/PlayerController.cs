using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //rigidbody is connected to the player
    private Rigidbody playerRB;

    //speed is established for player
    public float speed;
    private float xBound = 10.5f;
    private float zBound = 5.0f;
    
    Vector3 movement;

    /* if able to make character follow mouse movements, here is the beginning script
    Vector3 mousePos;
    */


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        PlayerFollowsMouse();
        PlayerBounds();
    }


    void PlayerMovement()
    {
        //player based on player input from keys
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        playerRB.MovePosition(playerRB.position + movement * speed * Time.deltaTime);
    }

    void PlayerFollowsMouse()
    {
        //player looks towards the mouse in 3D setting
        Plane playerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitDist = 0.0f;

        if (playerPlane.Raycast(ray, out hitDist))
        {
            Vector3 targetPoint = ray.GetPoint(hitDist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            targetRotation.x = 0;
            targetRotation.z = 0;
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 7f * Time.deltaTime);
        }
    }

    void PlayerBounds()
    {
        //player boundaries are set. black walls are triggers for bullets to explode.
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }

        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
    }
}
