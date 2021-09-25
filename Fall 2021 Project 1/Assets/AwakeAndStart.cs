using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    // Awake is called before Start and first update
    private void Awake()
    {
        Debug.Log("Awake called.");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start called.");
    }
}
