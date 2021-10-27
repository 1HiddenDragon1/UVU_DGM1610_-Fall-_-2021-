using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootForward : MonoBehaviour
{
    //speed is made editable for all assets at different speeds at the same time by having it public
    public float speed = 45.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //speed coding established for smooth movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
