using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //camera is attached to the player and offset
    public GameObject Player;
    private Vector3 offset = new Vector3(0, 6, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called after update to cause smooth camera movement
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
