using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponents : MonoBehaviour
{
    private Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            //the ! makes it switch to whatever it is not at the moment.
            //like saying "not on" or "not off"
            myLight.enabled = !myLight.enabled;
        }
    }
}
