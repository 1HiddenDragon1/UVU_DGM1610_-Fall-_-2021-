using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float DogTimer = 2.0f;
    private float Timer = 0f;
        


    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Timer > DogTimer)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Timer = 0;
        }
    }
}
