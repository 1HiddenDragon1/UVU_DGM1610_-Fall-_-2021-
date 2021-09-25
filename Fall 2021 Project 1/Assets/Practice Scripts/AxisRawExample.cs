using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AxisRawExample : MonoBehaviour
{
    //Axisraw movement is based on immediate movement from -1 to 0 to 1.
    //Great for using with 2D style games that may need exact movements
    public float range;
    public Text textOutput;

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned: " + h.ToString("F2");
    }
}