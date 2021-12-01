using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventBehaviour : MonoBehaviour
{
    UnityEvent castFireball;

    // Start is called before the first frame update
    void Start()
    {
        if (castFireball == null)
        {
            castFireball = new UnityEvent();
            castFireball.AddListener(Ping);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && castFireball != null)
        {
            castFireball.Invoke();
        }
    }

    void Ping()
    {
        Debug.Log("Ping");
    }
}
