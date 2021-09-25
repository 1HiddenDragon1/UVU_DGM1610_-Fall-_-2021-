using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    private float fixedUpdateTimer;
    private float UpdateTimer;

    private void FixedUpdate()
    {
        /* called every physics step
         * FixedUpdate intervals are consistent
         * used for regular updates such as:
         * adjusting physics (Ridgidbody) objects
         */
        Debug.Log("FixedUpdate time: " + Time.deltaTime);
    }
    void Update()
    {
        /* called every frame
         * used for regular updates such as:
         * moving non-physics objects,
         * simple timers,
         * receiving input.
         * note: update intervals vary
         */
        Debug.Log("Update time: " = Time.deltaTime);
    }
}
