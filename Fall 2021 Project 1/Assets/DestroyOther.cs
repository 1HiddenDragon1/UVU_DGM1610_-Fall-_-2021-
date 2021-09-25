using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOther : MonoBehaviour
{
    public GameObject other;

    void Update()
    {
        //destroys the game object without the script being deleted
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(other);
        }
    }
}
