using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketDestruction : MonoBehaviour
{
    //this code will destroy a summoned bullet or other gameObject after 1.5 seconds
    private void Start()
    {
        Destroy(gameObject, 1.5f);
    }
}
