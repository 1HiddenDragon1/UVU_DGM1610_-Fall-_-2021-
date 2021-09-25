using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatatypeScript : MonoBehaviour
{
    //gives different styles of locations for an object
    void Start()
    {
        //Value type variable
        //note: does not impact any other component
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0);

        //Reference type variable
        //note: due to "Transform" being a reference, it and other objects in the class "tran" are affected together.
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);
    }
}
