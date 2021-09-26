using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeating : MonoBehaviour
{
    public GameObject target;

    private void Start()
    {
        //causes the specified object to initially be spawned after 2 sec.
        //and then repeatedly spawned after 1 sec.
        InvokeRepeating("SpawnObject", 2, 1);
    }

    void SpawnObject()
    {
        //a range is provided where each spawnobject can be generated in.
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(target, new Vector3(x, 2, z), Quaternion.identity);
    }
}
