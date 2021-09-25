using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObjects : MonoBehaviour
{
    void Start()
    {
        //used to turn an object on or off in a scene
        //note: parent objects turned off, turn off child objects too
        gameObject.SetActive(false);
    }
}
