using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    //PlayerMovement script is referenced for the funtionality of this script
    private float speed = 30f;
    private PlayerMovement playerControllerScript;
    private float leftBound = -17f;

    // Start is called before the first frame update
    void Start()
    {
        //playercontrollerscript is able to find specific information in the other script
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //player runs if game isn't over
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        //obstacles are destroyed after reaching a certain distance. obstacles are specified by tag.
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
