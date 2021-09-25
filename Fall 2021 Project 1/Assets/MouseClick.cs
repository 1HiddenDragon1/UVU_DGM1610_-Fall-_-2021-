using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    //creates a rigidbody component
    private Rigidbody rb;

    private void Awake()
    {
        //makes the rigidbody connected to the initialization 
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        //the rigidbody is able to be effected by a mouse click and react as directed
        //note: the transform is negative because it causes the rigidbody to move opposite to its forward direction.
        rb.AddForce(-transform.forward * 500f);
        rb.useGravity = true;
    }
}
