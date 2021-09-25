using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour
{
    public GameObject myObject;

    void Start()
    {
        //checks to see if the gameobject is active and how it is active
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Heirarchy" + myObject.activeInHeirarchy);
    }
}
