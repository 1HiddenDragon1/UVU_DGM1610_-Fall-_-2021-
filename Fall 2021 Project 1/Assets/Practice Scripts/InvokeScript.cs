using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeScript : MonoBehaviour
{
    public GameObject target;

    private void Start()
    {
        //invoke brings an object into the game after a certain amount of time. In this case 2 sec.
        Invoke("SpawnObject", 2);
    }

    void SpawnObject()
    {
        //instantiate actually brings in the specified object at the location specified.
        Instantiate(target, new Vector3(0, 2, 0), Quaternion.identity);
    }
}
