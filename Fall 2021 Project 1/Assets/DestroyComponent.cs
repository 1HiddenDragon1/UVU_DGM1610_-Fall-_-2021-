using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyComponent : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            //able to destroy specific components in a game
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}
