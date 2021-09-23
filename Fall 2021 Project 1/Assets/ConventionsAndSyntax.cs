using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    void Start()
    {
        //this line is there to tell me the x position of the object

        /*HI!
         * this is how to do two lines!
         */
        Debug.Log(transform.position.x);
        
        if(transform.position.y <=5f)
        {
            Debug.Log("I'm about to hit the ground! Pull up!");
        }
    }
}
