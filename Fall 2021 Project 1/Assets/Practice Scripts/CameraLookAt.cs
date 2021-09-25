using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        //makes the camera automatically follow the movements of a specified game object
        transform.LookAt(target);
    }
}
