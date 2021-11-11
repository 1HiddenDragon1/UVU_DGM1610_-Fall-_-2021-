using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //gameobjects found in heirarchy
    private Rigidbody playerRb;
    private GameObject focalPoint;
    public GameObject powerupIndicator;

    //speed, powerup strenth and boolean are set
    public float speed = 5.0f;
    public float powerupStrength = 15.0f;
    public bool hasPowerup = false;

    // Start is called before the first frame update
    void Start()
    {
        //player rigidbody and focal point are selected for the game from the heirarchy
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        //player input is established for the player
        float forwardInput = Input.GetAxis("Vertical");

        //player movement is set and powerup indicator follows player movement
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }

    //powerup trigger is established
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
            powerupIndicator.gameObject.SetActive(true);
        }
    }

    //timer set for powerup
    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }

    //collision is made more impactful with powerup
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerup == true)
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);

            Debug.Log("Collision with " + collision.gameObject.name + " with powerup set to " + hasPowerup);
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }
}