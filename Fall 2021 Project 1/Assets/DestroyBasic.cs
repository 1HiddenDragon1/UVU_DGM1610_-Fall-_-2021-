using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBasic : MonoBehaviour
{
    void Update()
    {
        //game objects can be destroyed quite simply.
        //this will delete the script attached to it as well.
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}
